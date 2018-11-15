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
    /// Interaction logic for ConfirmationOrderWindow.xaml
    /// </summary>
    public partial class ConfirmationOrderWindow : Window
    {
        private AppController app;
        private User costumer;
        private Invoice invoice;
        public ConfirmationOrderWindow()
        {
            InitializeComponent();
            invoice = new Invoice();

            app = (AppController) Application.Current.Properties["ApplicationController"];
            costumer = app.getCostumer();
            invoice = costumer.getInvoice();

            this.LabelTotalPrice.Content = "Rp. " + invoice.getTotalPrice();

            displayDataIntoListview();
        }

        private void displayDataIntoListview()
        {
            /*
             * ===============================
             *  CHECKPOINT 3 NILAI 20
             * ===============================
             *       -> Aplikasi dapat menampilkan drink yang dipesan
             */
            foreach (Drink drink in costumer.getInvoice().getOrderedItems())
            {
                this.ListViewPurchased.Items.Add(drink.getTitle());
            }
        }

        private void onClickedButtonBeli(object sender, RoutedEventArgs e)
        {
            costumer.setName(this.LabelName.Text);
            /*
             * ===============================
             *  CHECKPOINT 4 NILAI 20
             * ===============================
             *      -> User memasukkan nama pelanggan Parjono
             */
            Console.WriteLine(costumer.getName().Equals("Parjono"));//seharusnya bernilai true

            DetailOrder detailOrder = new DetailOrder();
            detailOrder.Show();
        }

        private void ListViewPurchased_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
