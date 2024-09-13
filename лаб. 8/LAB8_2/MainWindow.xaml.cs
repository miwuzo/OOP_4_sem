using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Principal;

namespace LAB8_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectStr;
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataTable datTable;

        Computer acc = new Computer();
        public MainWindow()
        {
            InitializeComponent();

            connectStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            if (CheckDatabaseExists())
            {
                connect = new SqlConnection(connectStr);
            }
            else
            {
                CreateDatabase();
                connect = new SqlConnection(connectStr);
            }

            phonesGrid.RowEditEnding += PhonesGrid_RowEditEnding;

            Model_Box.SelectedItem = Model_Box.Items[1];
            TypeO_Box.SelectedItem = TypeO_Box.Items[1];
            TypeZ_Box.SelectedItem = TypeZ_Box.Items[1];
        }

        private bool CheckDatabaseExists()
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }


        //------------ Создание базы данных, если она не существует-----------
        private void CreateDatabase()
        {
            string databaseName = "lab8oop";
            bool databaseExists = CheckDatabaseExists(databaseName);

            if (!databaseExists)
            {
                SqlConnectionStringBuilder masterConnectionStringBuilder = new SqlConnectionStringBuilder(connectStr);
                masterConnectionStringBuilder.InitialCatalog = "master";

                using (SqlConnection masterConnection = new SqlConnection(masterConnectionStringBuilder.ConnectionString))
                {
                    masterConnection.Open();

                    string createDatabaseScript = $"CREATE DATABASE {databaseName}";
                    SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseScript, masterConnection);
                    createDatabaseCommand.ExecuteNonQuery();
                }
            }

            SqlConnectionStringBuilder databaseConnectionStringBuilder = new SqlConnectionStringBuilder(connectStr);
            databaseConnectionStringBuilder.InitialCatalog = databaseName;
            connectStr = databaseConnectionStringBuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                string createOwnersTableScript =
                    @"CREATE TABLE [dbo].[Processor] (
                [id] INT IDENTITY (1, 1) NOT NULL,
                [type] NVARCHAR (50) NOT NULL,
                [proizvoditel] NVARCHAR (50) NOT NULL,
                [seria] NCHAR (15) NOT NULL,
                [model] NVARCHAR (50) NOT NULL,
                [kolvoyader] INT NOT NULL,
                [chastota] INT NOT NULL, 
                [maxchastota] INT NOT NULL,
                [razrarhitect] INT NOT NULL, 
                [razmerkesha] NCHAR (15) NOT NULL,
                [ImageData] NVARCHAR(255) NULL,
                CONSTRAINT [PK__Owners__3214EC071237FB30] PRIMARY KEY CLUSTERED ([Id] ASC)
            )";
                SqlCommand createOwnersTableCommand = new SqlCommand(createOwnersTableScript, connection);
                createOwnersTableCommand.ExecuteNonQuery();

                string createAccountTableScript = @"CREATE TABLE [dbo].[Computer] (
            [id] INT IDENTITY (11000, 1) NOT NULL,
            [ownerId] INT NOT NULL,
            [type] NVARCHAR (50) NOT NULL,
            [videocard] NVARCHAR (50) NOT NULL,
            [sizeozy] INT NULL,
            [typeozy] NVARCHAR (50) NOT NULL,
            [sizedisk] INT NULL,
            [typedisk] NVARCHAR (50) NOT NULL,
            [date] DATETIME NOT NULL,
            CONSTRAINT [PK__Account__3214EC071237FB30] PRIMARY KEY CLUSTERED ([Id] ASC),
            CONSTRAINT [FK__Account__OwnerId__267ABA7A] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Processor] ([Id])
        )";
                SqlCommand createAccountTableCommand = new SqlCommand(createAccountTableScript, connection);
                createAccountTableCommand.ExecuteNonQuery();
            }
        }

        private bool CheckDatabaseExists(string databaseName)
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                string checkDatabaseScript = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";
                SqlCommand checkDatabaseCommand = new SqlCommand(checkDatabaseScript, connection);
                int databaseCount = (int)checkDatabaseCommand.ExecuteScalar();

                return databaseCount > 0;
            }
        }

        private void PhonesGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            UpdateDB();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load();

        }

        //====================== ЗАГРУЗКА ДАННЫХ ИЗ БД ========================
        public void Load()
        {
            string sql = "SELECT * FROM Computer JOIN Processor ON Computer.ownerId = Processor.id;";

            datTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectStr);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(datTable);
                phonesGrid.ItemsSource = datTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        // ============================== обновление данных в базе данных =======================
        private void UpdateDB()
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT  * FROM Computer JOIN Processor ON Computer.ownerId = Processor.id", connection))
                        {
                            adapter.RowUpdating += Adapter_RowUpdating;

                            SqlCommand updateCommand = new SqlCommand(
     "UPDATE c " +
     "SET c.videocard = @videocard, c.sizeozy = @sizeozy, c.typeozy = @typeozy, c.sizedisk = @sizedisk, c.typedisk = @typedisk, c.date = @date " +
     "FROM Computer AS c JOIN Processor AS p ON c.ownerId = p.id " +
     "WHERE c.[type] = @type; " +
     "UPDATE p " +
     "SET p.proizvoditel = @proizvoditel, p.seria = @seria, p.model = @model, p.kolvoyader = @kolvoyader, p.chastota = @chastota, p.maxchastota = @maxchastota, p.razrarhitect = @razrarhitect, p.razmerkesha = @razmerkesha " +
     "FROM Computer AS c JOIN Processor AS p ON c.ownerId = p.id " +
     "WHERE c.[type] = @type", connection, transaction);

                            updateCommand.Parameters.Add("@videocard", SqlDbType.NVarChar, 50, "videocard"); //
                            updateCommand.Parameters.Add("@sizeozy", SqlDbType.Int, 0, "sizeozy");//
                            updateCommand.Parameters.Add("@typeozy", SqlDbType.NVarChar, 50, "typeozy");//
                            updateCommand.Parameters.Add("@sizedisk", SqlDbType.Int, 0, "sizedisk"); //
                            updateCommand.Parameters.Add("@typedisk", SqlDbType.NVarChar, 50, "typedisk"); //
                            updateCommand.Parameters.Add("@date", SqlDbType.DateTime, 0, "date");//
                            updateCommand.Parameters.Add("@type", SqlDbType.NVarChar, 50, "type");//
                            updateCommand.Parameters.Add("@proizvoditel", SqlDbType.NVarChar, 50, "proizvoditel");//
                            updateCommand.Parameters.Add("@seria", SqlDbType.NChar, 15, "seria");//
                            updateCommand.Parameters.Add("@model", SqlDbType.NVarChar, 50, "model");//
                            updateCommand.Parameters.Add("@kolvoyader", SqlDbType.Int, 0, "kolvoyader"); //
                            updateCommand.Parameters.Add("@chastota", SqlDbType.Int, 0, "chastota"); //
                            updateCommand.Parameters.Add("@maxchastota", SqlDbType.Int, 0, "maxchastota"); //
                            updateCommand.Parameters.Add("@razrarhitect", SqlDbType.Int, 0, "razrarhitect"); //
                            updateCommand.Parameters.Add("@razmerkesha", SqlDbType.NChar, 15, "razmerkesha"); //

                            adapter.UpdateCommand = updateCommand;

                            adapter.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;
                            adapter.Update(datTable);
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ошибка при обновлении данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void Adapter_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
        {
            if (e.StatementType == StatementType.Update)
            {
                int chastota = Convert.ToInt32(e.Row["chastota"]);

                if (chastota < 0)
                {
                    e.Status = UpdateStatus.SkipCurrentRow;
                    throw new Exception("не может быть меньше нуля.");
                }
            }
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
            Load();
            //MessageBox.Show("Данные обновлены");
        }



        //===================================== удаление =========================================
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonesGrid.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)phonesGrid.SelectedItem;

                int id = Convert.ToInt32(selectedRow["id"]);

                DeleteFromDB(new List<int> { id });

            }
            Load();
        }

        //--------- удаление данных из базы данных ----------
        private void DeleteFromDB(List<int> recordIds)
        {
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (int recordId in recordIds)
                        {
                            DataRowView selectedRow = (DataRowView)phonesGrid.SelectedItem;
                            int walletValue = Convert.ToInt32(selectedRow["id"]);
                            if (walletValue > 1000)
                            {
                                SqlCommand deleteCommand = new SqlCommand(
                                    "DELETE FROM Computer WHERE id = @id", connection, transaction);
                                deleteCommand.Parameters.AddWithValue("@id", recordId);
                                deleteCommand.ExecuteNonQuery();
                            }
                            else
                            {
                                SqlCommand deleteCommand = new SqlCommand(
                                    "DELETE FROM Processor WHERE id = @id", connection, transaction);
                                deleteCommand.Parameters.AddWithValue("@id", recordId);
                                deleteCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ошибка при удалении данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }

        }


        // =============================== создание новой записи =====================================
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            this.acc.inprocessor.proizvoditel = Proizvoditel_Container.Text;  //
            this.acc.inprocessor.seria = Seria_Container.Text;                //
            //this.acc.inprocessor.kolvoyader =
            this.acc.inprocessor.chastota = Convert.ToInt32(Chastota_Slider.Value); //
          //  this.acc.inprocessor.maxchastota =
          //  this.acc.inprocessor.razrarhitect =
          //  this.acc.inprocessor.razmkesha =
            this.acc.type = TypeC_Container.Text;                             //
            this.acc.videocard = TypeV_Container.Text;
          //  this.acc.sizeozy =
          //  this.acc.sizedisk =
         //   this.acc.data = 


            if (Model_Box.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)Model_Box.SelectedItem;
                string selectedValue = selectedItem.Content.ToString();
                this.acc.inprocessor.model = selectedValue;
            }


            if (TypeO_Box.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)TypeO_Box.SelectedItem;
                string selectedValue = selectedItem.Content.ToString();
                this.acc.typeozy = selectedValue;
            }

            if (TypeZ_Box.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)TypeZ_Box.SelectedItem;
                string selectedValue = selectedItem.Content.ToString();
                this.acc.typedisk = selectedValue;
            }

            try
            {
                if (ValidateValue())
                {
                    using (SqlConnection connection = new SqlConnection(connectStr))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();

                        try
                        {
                            SqlCommand c = new SqlCommand();
                            c.Connection = connection;
                            c.Transaction = transaction;

                            c.CommandText = "INSERT Processor values (@proizvoditel, @seria, @model, @kolvoyader, @chastota, @maxchastota, @razrarhitect, @razmerkesha, @ImageData);";
                            c.Parameters.AddWithValue("@proizvoditel", this.acc.inprocessor.proizvoditel);
                            c.Parameters.AddWithValue("@seria", this.acc.inprocessor.seria);
                            c.Parameters.AddWithValue("@model", this.acc.inprocessor.model);
                            c.Parameters.AddWithValue("@kolvoyader", this.acc.inprocessor.kolvoyader);
                            c.Parameters.AddWithValue("@chastota", this.acc.inprocessor.chastota);
                            c.Parameters.AddWithValue("@maxchastota", this.acc.inprocessor.maxchastota);
                            c.Parameters.AddWithValue("@razrarhitect", this.acc.inprocessor.razrarhitect);
                            c.Parameters.AddWithValue("@razmerkesha", this.acc.inprocessor.razmkesha);
                            c.Parameters.AddWithValue("@imageData", imageUri);
                            c.ExecuteNonQuery();

                            c.CommandText = "SELECT TOP 1 id\r\nFROM Processor\r\nORDER BY id DESC;";
                            int ownerId = Convert.ToInt32(c.ExecuteScalar());

                            c.CommandText = "INSERT INTO Computer (ownerId, type, videocard, sizeozy, typeozy, sizedisk, typedisk, date) VALUES ( @ownerId, @type, @videocard, @sizeozy, @typeozy, @sizedisk, @typedisk, @date);";
                            c.Parameters.AddWithValue("@ownerId", ownerId);
                            c.Parameters.AddWithValue("@type", this.acc.type);
                            c.Parameters.AddWithValue("@videocard", this.acc.videocard);
                            c.Parameters.AddWithValue("@sizeozy", this.acc.sizeozy);
                            c.Parameters.AddWithValue("@typeozy", this.acc.typeozy);
                            c.Parameters.AddWithValue("@sizedisk", this.acc.sizedisk);
                            c.Parameters.AddWithValue("@typedisk", this.acc.typedisk);
                            c.Parameters.AddWithValue("@date", this.acc.data);
                            c.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Успешно!!", "Поздравляем", MessageBoxButton.OK, MessageBoxImage.Information);
                            acc = new Computer();

                            /*FIO_Container.Clear();
                            Pasport_Container.Clear();
                            BirthD_Picker.SelectedDate = null;
                            ProductImage.Source = null;*/
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка при создании записи: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось добавить данные, проверьте правильность вводимых данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (SqlException ex)
            {
                string errormsg = "";
                foreach (SqlError err in ex.Errors)
                {
                    errormsg += err.Message + ",";
                }
                MessageBox.Show(errormsg, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        ///--------- выборы combobox ----------
        private void Model_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            this.acc.inprocessor.model = comboBox.Text;
        }
        private void Type_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            this.acc.typeozy = comboBox.Text;
        }
        private void Type_Z_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            this.acc.typedisk = comboBox.Text;
        }

        //--------- выбор radio ----------
        private void yad_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.IsChecked == true)
            {
                switch (radioButton.Name)
                {
                    case "yad8":
                        this.acc.inprocessor.kolvoyader = 8;
                        break;
                    case "yad16":
                        this.acc.inprocessor.kolvoyader = 16;
                        break;
                    case "yad32":
                        this.acc.inprocessor.kolvoyader = 32;
                        break;
                }
            }
        }

        private void maxyad_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.IsChecked == true)
            {
                switch (radioButton.Name)
                {
                    case "max1":
                        this.acc.inprocessor.maxchastota = 320;
                        break;
                    case "max2":
                        this.acc.inprocessor.maxchastota = 640;
                        break;
                    case "max3":
                        this.acc.inprocessor.maxchastota = 1240;
                        break;
                }
            }
        }

        private void razr_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton2 = sender as RadioButton;

            if (radioButton2 != null && radioButton2.IsChecked == true)
            {
                switch (radioButton2.Name)
                {
                    case "razr1":
                        this.acc.inprocessor.razrarhitect = 32;
                        break;
                    case "razr2":
                        this.acc.inprocessor.razrarhitect = 64;
                        break;
                }
            }
        }

        Processor processor = new Processor();

        private void kesh_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.IsChecked == true)
            {
                switch (radioButton.Name)
                {
                    case "l1":
                        this.acc.inprocessor.razmkesha = "l1";
                        break;
                    case "l2":
                        this.acc.inprocessor.razmkesha = "l2";
                        break;
                    case "l3":
                        this.acc.inprocessor.razmkesha = "l3";
                        break;
                }
            }
        }

        private void sizeo_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.IsChecked == true)
            {
                switch (radioButton.Name)
                {
                    case "so1":
                        this.acc.sizeozy = 1;
                        break;
                    case "so2":
                        this.acc.sizeozy = 2;
                        break;
                    case "so3":
                        this.acc.sizeozy = 3;
                        break;
                }
            }
        }

        private void size_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.IsChecked == true)
            {
                switch (radioButton.Name)
                {
                    case "s1":
                        this.acc.sizedisk = 1;
                        break;
                    case "s2":
                        this.acc.sizedisk = 2;
                        break;
                    case "s3":
                        this.acc.sizedisk = 3;
                        break;
                }
            }
        }

        //--------- выбор даты ----------
        private void BirthD_Picker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = BirthD_Picker.SelectedDate;
            if (selectedDate != null)
            {
                this.acc.data = selectedDate.Value;
            }
        }

        //-------------- слайдер --------------
        private void Chastota_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            int sliderVal = Convert.ToInt32(Chastota_Slider.Value);
            this.ChastotaSlider.Text = sliderVal.ToString();
            this.acc.inprocessor.chastota = sliderVal;
        }

        private int currentIndex = -1;

        // --------- вперед назад ----------
        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                phonesGrid.SelectedIndex = currentIndex;
                phonesGrid.ScrollIntoView(phonesGrid.SelectedItem);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < phonesGrid.Items.Count - 1)
            {
                currentIndex++;
                phonesGrid.SelectedIndex = currentIndex;
                phonesGrid.ScrollIntoView(phonesGrid.SelectedItem);
            }
        }

        // ----------- поиск ----------
        private DataTable GetDataFromDatabase(string _query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectStr))
                {
                    SqlCommand command = new SqlCommand(_query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных из базы данных: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return dataTable;
        }

        private string imageUri;

        //----------------- добавить изображение -----------------
        private void addImg_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
                bool? response = open.ShowDialog();
                if (response.HasValue)
                {
                    if (response.Value == true)
                    {
                        string path = open.FileName;
                        BitmapImage bi3 = new BitmapImage();
                        bi3.BeginInit();
                        bi3.UriSource = new Uri(path);
                        bi3.EndInit();
                        ProductImage.Stretch = Stretch.Fill;
                        ProductImage.Source = bi3;
                        imageUri = path;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка: загрузка изображения");
            }
        }

        // --------- закрытие приложения ----------
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connect.Close();
        }

        

        //=============================== ЗАПРОСЫ К БД =================================
        private void Wallet_Search_Click(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = GetDataFromDatabase($"exec Find_type @razmerkesha = \'{Wallet_Search_tb.Text}\'");
            phonesGrid.ItemsSource = dataTable.DefaultView;
        }

        private void FIO_Search_Click(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = GetDataFromDatabase($"exec Find_Surname @proizvoditel = \'{FIO_SEARCH_TB.Text}\'");
            phonesGrid.ItemsSource = dataTable.DefaultView;
        }

       

        //=============================================================================

        //----------------- валидация -----------------
        private bool ValidateValue()
        {
            string proizv = Proizvoditel_Container.Text;
            string typecom = TypeC_Container.Text;  
            string typevid = TypeV_Container.Text;
            string date = BirthD_Picker.Text;
            string seria = Seria_Container.Text;


            if (!ValidateFIO(proizv))
            {
                if (proizv.Length > 40)
                {
                    return false;
                }
                if (typecom.Length > 40)
                {
                    return false;
                }
                if (typevid.Length > 40)
                {
                    return false;
                }

                MessageBox.Show("ошибка в текстовом блоке");
                return false;
            }


            if (!validateDate())
            {
                MessageBox.Show("Недопустимое значение даты");
                return false;
            }
            if (!validatePassport(seria))
            {
                MessageBox.Show("Недопустимое значение (Верный вариант: HP7434236)");
                return false;
            }

            if (string.IsNullOrEmpty(imageUri))
            {
                MessageBox.Show("Нет изображения");
                return false;
            }


            return true;
        }

        private bool validatePassport(string passport)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{2}\d{7}$");
            if (!regex.IsMatch(passport))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(passport))
            {
                return false;
            }
            return true;
        }

        private bool ValidateFIO(string fio)
        {
            Regex regex = new Regex(@"^[a-zA-Zа-яА-Я]+$");
            if (!regex.IsMatch(fio))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(fio))
            {
                return false;
            }
            return true;
        }

        public bool validateDate()
        {
            DateTime? selectedDate = BirthD_Picker.SelectedDate;
            if (selectedDate != null)
            {
                if (selectedDate.Value > DateTime.Now)
                {
                    MessageBox.Show("Дата не может быть больше текущей даты");
                    return false;
                }
                return true;
            }

            return false;
        }



    }
}
