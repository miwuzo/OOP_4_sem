using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LAB_02
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        private List<computer> Computers = new List<computer>();
        public List<computer> computerList = new List<computer>();

        public Form1()
        {
            InitializeComponent();
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void Form1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            actionUser.Text = "Нажата кнопка";
        }
        void timer_Tick(object sender, EventArgs e)
        {
            dataLabel.Text = DateTime.Now.ToLongDateString();
            actionUser.Text = DateTime.Now.ToLongTimeString();
        }
        public void SerialXML()
        {
            using (FileStream fs = new FileStream("yana.xml", FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(computerList.GetType());
                xml.Serialize(fs, computerList);
            }
            MessageBox.Show("Данные успешно сохранены!", "Успех!");
        }
        public void ReturnXML()
        {
            using (FileStream fs = new FileStream("yana.xml", FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(computerList.GetType());
                List<computer> accs = new List<computer>();
                accs = xml.Deserialize(fs) as List<computer>;
                foreach (var acc in accs)
                    computerList.Add(acc);
            }
        }
        private void DataGridRowAdd(DataGridView dgv)
        {
            int kolich = computerList.Count;
            int y = 0;
            do
            {
                y++;




                int Index = dataGridView1.Rows.Add();
                dgv.Rows[Index].Cells["proizv"].Value = computerList[Index].inprocessor.proizvoditel;
                dgv.Rows[Index].Cells["seria"].Value = computerList[Index].inprocessor.seria;
                dgv.Rows[Index].Cells["model"].Value = computerList[Index].inprocessor.model;
                dgv.Rows[Index].Cells["kol_yader"].Value = computerList[Index].inprocessor.kolvoyader;
                dgv.Rows[Index].Cells["chastota"].Value = computerList[Index].inprocessor.chastota;
                dgv.Rows[Index].Cells["max_chastota"].Value = computerList[Index].inprocessor.maxchastota;
                dgv.Rows[Index].Cells["razryad_arph"].Value = computerList[Index].inprocessor.razrarhitect;
                dgv.Rows[Index].Cells["razmer_cash"].Value = computerList[Index].inprocessor.razmkesha;
                dgv.Rows[Index].Cells["processor"].Value = computerList[Index].processorr;
                dgv.Rows[Index].Cells["type_computer"].Value = computerList[Index].type;
                dgv.Rows[Index].Cells["videocard"].Value = computerList[Index].videocard;
                dgv.Rows[Index].Cells["size_OZY"].Value = computerList[Index].sizeozy;
                dgv.Rows[Index].Cells["type_OZY"].Value = computerList[Index].typeozy;
                dgv.Rows[Index].Cells["size_hard_disk"].Value = computerList[Index].sizedisk;
                dgv.Rows[Index].Cells["type_hard_disk"].Value = computerList[Index].typedisk;
                dgv.Rows[Index].Cells["date"].Value = computerList[Index].data;

                // StatusObjects.Text = "Количество: " + (Computers.Count / 3);

                StatusObjects.Text = "Количество: " + (dataGridView1.RowCount - 1);
            }
            while (y < kolich);






        }
        public void Clear()
        {
            typecomputer.ResetText();
            typeprocessor.ResetText();
            videocarta.ResetText();
            sizozy.ResetText();
            tip1.Checked = false;
            tip2.Checked = false;
            tip3.Checked = false;
            tipdisk.ResetText();
            textBox1.ResetText();
            data.ResetText();
            textBox1.ResetText();
            proizvoditel.ResetText();
            seriya.ResetText();
            moddel.ResetText();
            yadra.ResetText();
            textBox2.ResetText();
            maxchast.ResetText();
            arh1.Checked = false;
            arh2.Checked = false;
            kesh.ResetText();
        }
        
        private void button1_Click(object sender, EventArgs e)
          {
              try
              {

                  if (ValidateChildren())
                  {
                    Computers.Add(new computer(new processor(proizvoditel.Text, moddel.Text, Convert.ToInt32(textBox2.Text)), Convert.ToInt32(sizozy.Text)));

                    string type1 = typecomputer.Text;
                      string processorr1 = typeprocessor.Text;
                      string videocard1 = videocarta.Text;
                      int sizeozy1 = (int)sizozy.Value;
                      string typeozy1 = string.Empty;
                      if (tip1.Checked)
                      {
                          typeozy1 = tip1.Text;
                      }
                      else if (tip2.Checked)
                      {
                          typeozy1 = tip2.Text;
                      }
                      else if (tip3.Checked)
                      {
                          typeozy1 = tip3.Text;
                      }
                      string typedisk1 = tipdisk.Text;
                      int sizedisk1 = Convert.ToInt32(textBox1.Text);
                      DateTime data1 = data.Value;

                      string proizvoditel1 = proizvoditel.Text;
                      string seria1 = seriya.Text;
                      string model1 = moddel.Text;
                      int kolvoyader1 = (int)yadra.Value;
                      int chastota1 = Convert.ToInt32(textBox2.Text);
                      int maxchastota1 = Convert.ToInt32(maxchast.Text);
                      string razrarhitect1 = string.Empty;
                      if (arh1.Checked)
                      {
                          razrarhitect1 = arh1.Text;
                      }
                      else if (arh2.Checked)
                      {
                          razrarhitect1 = arh2.Text;
                      }
                      string razmkesha1 = kesh.Text;

                      computerList.Add(new computer(new processor(proizvoditel1, seria1, model1, kolvoyader1, chastota1, maxchastota1, razrarhitect1, razmkesha1), processorr1, type1, videocard1, sizeozy1, typeozy1, sizedisk1, typedisk1, data1));
                     
                    DataGridRowAdd(dataGridView1);
                      Clear();
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Произошла ошибка: " + ex.Message);
              }


          }
  

        private void sizdisk_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(sizdisk.Value);
        }

        private void chast_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(chast.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SerialXML();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                

                // ReturnXML();
                using (FileStream fs = new FileStream("yana.xml", FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(computerList.GetType());
                    List<computer> accs = new List<computer>();
                    accs = xml.Deserialize(fs) as List<computer>;
                    foreach (var acc in accs)
                        computerList.Add(acc);
                }



                using (FileStream fs = new FileStream("yana.xml", FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(Computers.GetType());
                    List<computer> accs = new List<computer>();
                    accs = xml.Deserialize(fs) as List<computer>;
                    foreach (var acc in accs)
                        Computers.Add(acc);
                }




                DataGridRowAdd(dataGridView1);
                MessageBox.Show("Данные успешно восстановлены!", "Успех!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void typeprocessor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(typeprocessor.Text) || !IsString(typeprocessor.Text))
            {
                errorProvider1.SetError(typeprocessor, "Неправильный формат ввода");
                e.Cancel = true;
            }
        }
        private bool IsString(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void typeprocessor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(typeprocessor, "");
            errorProvider1.Clear();
        }

        private void typecomputer_Validating(object sender, CancelEventArgs e)
        {
            string inputValue = typecomputer.Text.Trim();
            if (string.IsNullOrEmpty(typecomputer.Text))
            {
                errorProvider2.SetError(typecomputer, "Можно вводить только строковые значения");
                e.Cancel = true;
            }
            else if (!typecomputer.Items.Contains(inputValue))
            {
                errorProvider2.SetError(typecomputer, "Выберите значение из списка");
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(typecomputer, ""); // Очищаем сообщение об ошибке, если значение валидно
            }
        }

        private void typecomputer_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(typecomputer, "");
            errorProvider2.Clear();
        }

        private void videocarta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(videocarta.Text) || !IsString(videocarta.Text))
            {
                errorProvider3.SetError(videocarta, "Неправильный формат ввода");
                e.Cancel = true;
            }
        }

        private void videocarta_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(videocarta, "");
            errorProvider3.Clear();
        }

        private void sizozy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(sizozy.Text) || (sizozy.Value == 0))
            {
                errorProvider4.SetError(sizozy, "Неправильный формат ввода");
                e.Cancel = true;
            }
        }

        private void sizozy_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(sizozy, "");
            errorProvider4.Clear();
        }

        private void tipdisk_Validating(object sender, CancelEventArgs e)
        {
            string inputValue2 = tipdisk.Text.Trim();
            if (string.IsNullOrEmpty(tipdisk.Text))
            {
                errorProvider5.SetError(tipdisk, "Можно вводить только строковые значения");
                e.Cancel = true;
            }
            else if (!tipdisk.Items.Contains(inputValue2))
            {
                errorProvider5.SetError(tipdisk, "Выберите значение из списка");
                e.Cancel = true;
            }
            else
            {
                errorProvider5.SetError(tipdisk, "");
            }
        }

        private void tipdisk_Validated(object sender, EventArgs e)
        {
            errorProvider5.SetError(tipdisk, "");
            errorProvider5.Clear();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider6.SetError(textBox1, "");
            errorProvider6.Clear();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || (textBox1.Text == "0"))
            {
                errorProvider6.SetError(textBox1, "Неправильный формат ввода");
                e.Cancel = true;
            }
        }

        private void proizvoditel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(proizvoditel.Text) || !IsString(proizvoditel.Text))
            {
                errorProvider7.SetError(proizvoditel, "Неправильный формат ввода");
                e.Cancel = true;
            }
        }

        private void proizvoditel_Validated(object sender, EventArgs e)
        {
            errorProvider7.SetError(proizvoditel, "");
            errorProvider7.Clear();
        }

        private void moddel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(moddel.Text) || !IsString(moddel.Text))
            {
                errorProvider8.SetError(moddel, "Неправильный формат ввода");
                e.Cancel = true;
            }
        }

        private void moddel_Validated(object sender, EventArgs e)
        {
            errorProvider8.SetError(moddel, "");
            errorProvider8.Clear();
        }








        private void Form1_Load(object sender, EventArgs e)
        {
            seriya.Mask = "00/00";
            seriya.ValidatingType = typeof(System.DateTime);
            seriya.Validating += seriya_Validating;
        }


        private void seriya_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(seriya.Text))
            {
                e.Cancel = true;
                errorProvider9.SetError(seriya, "Введите данные!");
            }
            else if (seriya.Text.Length != 3)
            {
                e.Cancel = true;
                errorProvider9.SetError(seriya, "Введите корректные данные!");
            }
            else
            {
                for (int i = 0; i < seriya.Text.Length; i++)
                {
                    if ((i == 0 || i == 1) && Char.IsDigit(seriya.Text[i]))
                    {
                        e.Cancel = true;
                        errorProvider9.SetError(seriya, "Введите корректные данные!");
                    }
                }
            }
        }

        private void seriya_Validated(object sender, EventArgs e)
        {
            errorProvider9.SetError(seriya, "");
            errorProvider9.Clear();
        }

        private void yadra_Validated(object sender, EventArgs e)
        {
            errorProvider10.SetError(yadra, "");
            errorProvider10.Clear();
        }

        private void yadra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(yadra.Text) || (yadra.Value == 0))
            {
                errorProvider10.SetError(yadra, "Неправильный формат ввода");
                e.Cancel = true;
            }
        }
        private void kesh_Validating(object sender, CancelEventArgs e)
        {
                for (int i = 0; i < kesh.Text.Length; i++)
                {
                    if ( !Char.IsDigit(kesh.Text[i]))
                    {
                        e.Cancel = true;
                        errorProvider12.SetError(kesh, "Введите корректные данные!");
                    }
                }
         }

        private void kesh_Validated(object sender, EventArgs e)
        {
            errorProvider12.SetError(kesh, "");
            errorProvider12.Clear();
        }


        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(textBox2.Text) || (textBox2.Text == "0"))
            {
                errorProvider11.SetError(textBox2, "Неправильный формат ввода");
                e.Cancel = true;
            }
            if (int.Parse(textBox2.Text) > int.Parse(maxchast.Text))
            {
                errorProvider11.SetError(textBox2, "Частота не может быть больше максималной частоты");
                e.Cancel = true;
            }*/
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider11.SetError(textBox2, "");
            errorProvider11.Clear();
        }

        private void chast_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(textBox2.Text) > int.Parse(maxchast.Text))
            {
                errorProvider11.SetError(textBox2, "Частота не может быть больше максималной частоты");
                e.Cancel = true;
            }
            if (string.IsNullOrEmpty(textBox2.Text) || (textBox2.Text == "0"))
            {
                errorProvider11.SetError(textBox2, "Неправильный формат ввода");
                e.Cancel = true;
            }
        }

        private void chast_Validated(object sender, EventArgs e)
        {
            errorProvider11.SetError(textBox2, "");
            errorProvider11.Clear();
        }

        private void maxchast_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Enabled == true || chast.Enabled == true)
            {
                if (int.Parse(textBox2.Text) > int.Parse(maxchast.Text))
                {
                    errorProvider13.SetError(maxchast, "Частота не может быть больше максималной частоты");
                    e.Cancel = true;
                }
                if (string.IsNullOrEmpty(maxchast.Text) || (maxchast.Text == "0"))
                {
                    errorProvider13.SetError(maxchast, "Неправильный формат ввода");
                    e.Cancel = true;
                }
            }
        }

        private void maxchast_Validated(object sender, EventArgs e)
        {
            errorProvider13.SetError(maxchast, "");
            errorProvider13.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (string.IsNullOrEmpty(maxchast.Text))
            {
                chast.Enabled = false; 
                textBox2.Enabled = false;
            }
            else
            {
                chast.Enabled = true;
                textBox2.Enabled = true; 
            }
            if(chast.Enabled == true && textBox2.Enabled == true)
            {
                maxchast.ReadOnly = true;
            }
            if (chast.Enabled == false && textBox2.Enabled == false)
            {
                maxchast.ReadOnly = false;
            }
        }

      
        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь навел на кнопку";
        }

        private void RestoreButton_MouseEnter(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь навел на кнопку";
        }

        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь навел на кнопку";
        }

        private void TypeComp(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает тип компьютера";
        }

        private void TypePr(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает процессор";
        }

       

        private void Ozy(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает размер OZY";
        }

        private void tip(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает тип OZY";
        }

        private void HardD(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает жесткий диск";
        }

        private void sizD(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает размер жесткого диска";
        }

        private void dat(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает дату";
        }

        private void proc(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает параметры процессора";
        }

        private void videoc(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает видеокарту";
        }

        private void pro(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь выбирает параметры процессора";
        }

        private void menu1(object sender, EventArgs e)
        {
            actionUser.Text = "Пользователь на строке меню";
        }

        private void ОпрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 1206 b \nРазработчик: Чёрная Я.Р.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFind searchForm = new FormFind(Computers);

            searchForm.Show();
        }
    }
}
