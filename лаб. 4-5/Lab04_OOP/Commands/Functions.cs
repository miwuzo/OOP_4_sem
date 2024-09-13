using Lab04_OOP.Products;
using System;
using Lab04_OOP.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Lab04_OOP.Commands
{
    public class Functions
    {
        protected internal static MainWindow mainWindow;
        public Functions() { }
        public Functions(MainWindow mainWindow)
        {
            Functions.mainWindow = mainWindow;
        }
        public void RemoveDataGridItem(ObservableCollection<Product> Products)
        {
            Guid product_id = (mainWindow.ProductsDataGrid.SelectedItem as Product).ID;
            Product product = (from pr in Products where pr.ID == product_id select pr).SingleOrDefault();
            Products.Remove(product);
            mainWindow.ProductsDataGrid.ItemsSource = Products;
        }

        public void OpenProductForm(ObservableCollection<Product> Products, Functions functions)
        {
            InputProduct inputProduct = new InputProduct(Products, functions);
            inputProduct.Owner = mainWindow;

            inputProduct.AddBinding();
            inputProduct.Show();
        }
        public void ChangeProductForm(ObservableCollection<Product> Products, Functions functions)
        {
            InputProduct inputProduct = new InputProduct(Products, functions);
            inputProduct.Owner = mainWindow;

            int selectedIndex = mainWindow.ProductsDataGrid.SelectedIndex;
            Product selectedProduct = mainWindow.ProductsDataGrid.SelectedItem as Product;

            inputProduct.ChangeBinding(mainWindow.ProductsDataGrid.SelectedIndex);
            inputProduct.Title_TextBox.Text = (mainWindow.ProductsDataGrid.SelectedItem as Product).Title;
            inputProduct.Description_TextBox.Text = (mainWindow.ProductsDataGrid.SelectedItem as Product).Description;
            inputProduct.Price_Slider.Text = ((mainWindow.ProductsDataGrid.SelectedItem as Product).Price).ToString();
            if ((mainWindow.ProductsDataGrid.SelectedItem as Product).Type == ProductType.Vip)
                inputProduct.Type_ComboBox.SelectedIndex = 0;
            if ((mainWindow.ProductsDataGrid.SelectedItem as Product).Type == ProductType.Usual)
                inputProduct.Type_ComboBox.SelectedIndex = 1;

            string imagePath = selectedProduct.Image;
            if (/*!string.IsNullOrEmpty(imagePath) && inputProduct.ProductImage.Source == null*/ true)
            {
                inputProduct.ProductImage.Source = new BitmapImage(new Uri(imagePath));
            }


            inputProduct.Show();
        }

        /*   public void ChangeInDataGrid(string title, string description, double price, string uri, ProductType productType, ObservableCollection<Product> Products, int selectIndex)
           {
               string existingImagePath = Products[selectIndex].Image;
               Products[selectIndex] = new Product()
               {
                   Title = title,
                   Description = description,
                   Price = price,
                   Image = existingImagePath,
                   Type = productType
               };

               mainWindow.ProductsDataGrid.Items.Refresh();
           }*/

        public void ChangeInDataGrid(string title, string description, double price, string uri, ProductType productType, ObservableCollection<Product> Products, int selectIndex)
        {
            string existingImagePath = Products[selectIndex].Image;
            Products[selectIndex] = new Product()
            {
                Title = title,
                Description = description,
                Price = price,
                Image = uri,
                Type = productType
            };

            mainWindow.ProductsDataGrid.Items.Refresh();
        }






        public void AddToDataGrid(string title, string description, double price, string uri, ProductType productType, ObservableCollection<Product> Products)
    {
        Products.Add(new Product(title, description, price, uri, productType));
    }

        public bool ValidateInputProduct(string? title, string? description, string? uri, string? price)
        {
            if (string.IsNullOrWhiteSpace(title))
                return false;

            if (string.IsNullOrWhiteSpace(description))
                return false;

            /* if (string.IsNullOrWhiteSpace(uri))
                 return false;*/

            if (string.IsNullOrWhiteSpace(price))
                return false;

            if (price.Contains("-") || !double.TryParse(price, out double priceValue))
                return false;

            return true;
        }

        public bool ValidateInputProductAdd(string? title, string? description, string? uri, string? price)
        {
            if (string.IsNullOrWhiteSpace(title))
                return false;

            if (string.IsNullOrWhiteSpace(description))
                return false;

            if (string.IsNullOrWhiteSpace(uri))
                return false;

            if (string.IsNullOrWhiteSpace(price))
                return false;

            if (price.Contains("-") || !double.TryParse(price, out double priceValue))
                return false;

            return true;
        }

    }
}