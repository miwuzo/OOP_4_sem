using Lab04_OOP.Commands;
using Lab04_OOP.Products;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Application = System.Windows.Application;


namespace Lab04_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected internal ObservableCollection<Product> Products = new ObservableCollection<Product>();
        private Functions functions;
        public MainWindow()
        {
            InitializeComponent();
            functions = new Functions(this);

            Cursor customCursor = new Cursor("C:\\Users\\yana\\OneDrive\\Рабочий стол\\Lab04_OOP\\Img\\cursor.cur");
            this.Cursor = customCursor;

        }

        private void ProductsDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            string jsonFilePath = "ProductsData.json";
            List<Product> lstPr;

            if (File.Exists(jsonFilePath))
            {
                using (FileStream file = new FileStream(jsonFilePath, FileMode.Open))
                {
                    lstPr = JsonSerializer.Deserialize<List<Product>>(file);
                }
            }
            else
            {
                lstPr = new List<Product>();
            }

            foreach (Product pr in lstPr)
            {
                Products.Add(pr);
            }

            ProductsDataGrid.ItemsSource = Products;

            LoadLanguageDictionary("ru");
        }
        private void LoadLanguageDictionary(string culture)
        {
            string dictPath = $"resources.{culture}.xaml";
            Uri dictUri = new Uri(dictPath, UriKind.Relative);

            ResourceDictionary langDict = Application.LoadComponent(dictUri) as ResourceDictionary;

            ResourceDictionary oldLangDict = Application.Current.Resources.MergedDictionaries
                .FirstOrDefault(dictionary => dictionary.Source != null && dictionary.Source.OriginalString == dictPath);

            Application.Current.Resources.MergedDictionaries.Add(langDict);

        }

        private void ChangeLanguageButton_Click(object sender, RoutedEventArgs e)
        {
            string language = ((Button)sender).Tag.ToString();

            LoadLanguageDictionary(language);
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Product> lstPr = new List<Product>();
            foreach (Product pr in Products)
                lstPr.Add(pr);
            using (FileStream file = new FileStream("ProductsData.json", FileMode.Create))
            {
                JsonSerializer.Serialize<List<Product>>(file, lstPr);
            }

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                ProductsDataGrid.ItemsSource = Products;
            }
            else
            {
                string searchText = SearchBox.Text;
                var regex = new Regex(searchText, RegexOptions.IgnoreCase);

                var searchedProducts = Products.Where(p => regex.IsMatch(p.Title) || regex.IsMatch(p.Price.ToString())).ToList();

                ProductsDataGrid.ItemsSource = new ObservableCollection<Product>(searchedProducts);
            }
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            double minPrice, maxPrice;
            bool isMinValid = double.TryParse(Min.Text, out minPrice);
            bool isMaxValid = double.TryParse(Max.Text, out maxPrice);

            if (isMinValid && isMaxValid)
            {
                ICollectionView view = CollectionViewSource.GetDefaultView(ProductsDataGrid.ItemsSource);
                view.Filter = (item) =>
                {
                    Product product = item as Product;
                    return product.Price >= minPrice && product.Price <= maxPrice;
                };
            }
            else
            {

                ICollectionView view = CollectionViewSource.GetDefaultView(ProductsDataGrid.ItemsSource);
                view.Filter = null;
            }
        }


        private void RemoveDataGridItem(object sender, ExecutedRoutedEventArgs e)
        {
            functions.RemoveDataGridItem(Products);
        }
        private void AddProductInputForm_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            functions.OpenProductForm(Products, functions);
        }
        private void ChangeDataGridItem(object sender, ExecutedRoutedEventArgs e)
        {
            functions.ChangeProductForm(Products, functions);
        }




    }
}