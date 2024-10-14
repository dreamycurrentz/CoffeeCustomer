using CoffeeCustomers.DataProvider;
using CoffeeCustomers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CoffeeCustomers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerDataProvider _customerDataProvider;

        public MainWindow()
        {
            InitializeComponent();
            ///this.Loaded += MainWindow_Loaded;
            _customerDataProvider = new CustomerDataProvider();
            LoadCustomers();
            SaveCustomers();

        }

        private void LoadCustomers()
        {
            customerListView.Items.Clear();
            var customers = _customerDataProvider.LoadCustomers();

            foreach (var customer in customers)
            {
                customerListView.Items.Add(customer);
            }
        }

        private void SaveCustomers()
        {
            _customerDataProvider.SaveCustomers(customerListView.Items.OfType<Customer>());
        }
      

        private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMove_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(customerListGrid);

            int newColumn = column == 0 ? 2 : 0;

            Grid.SetColumn(customerListGrid, newColumn);
        }
    }
}
