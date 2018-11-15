using HepiCoffe.Controller;
using HepiCoffe.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace HepiCoffe.View
{
    /// <summary>
    /// Interaction logic for DetailOrder.xaml
    /// </summary>
    public partial class DetailOrder : Window
    {
        private AppController app;
        private User costumer;
        private Invoice invoice;
        public DetailOrder()
        {
            InitializeComponent();
            costumer = new User();
            invoice = new Invoice();

            app = (AppController)Application.Current.Properties["ApplicationController"];
            costumer = app.getCostumer();
            invoice = costumer.getInvoice();

            this.lblName.Content = costumer.getName();
            this.lblTotal.Content = "Rp. " + invoice.getTotalPrice() / 2;

            displayDataIntoListview();
        }

        private void displayDataIntoListview()
        {
            foreach (Drink drink in costumer.getInvoice().getOrderedItems())
            {
                this.ListViewPurchased.Items.Add(drink.getTitle());
            }
        }
    }
}
