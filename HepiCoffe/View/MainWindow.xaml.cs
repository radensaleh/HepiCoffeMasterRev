using HepiCoffe.Controller;
using HepiCoffe.Model;
using HepiCoffe.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HepiCoffe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User newCostumer;
        private Invoice newInvoice;
        private AppController app;
        public MainWindow()
        {
            InitializeComponent();
            newCostumer = new User();
            newInvoice = new Invoice();

            app = new AppController();
            app.addCostumer(newCostumer);

            Application.Current.Properties["ApplicationController"] = app;
        }

        private void onClickedButtonCappucino(object sender, RoutedEventArgs e)
        {
            Drink cappucino = app.getDrinkByName("Cappucino");
            newInvoice.addOrder(cappucino);
            this.buttonCappucino.IsEnabled = false;
        }


        private void onClickedButtonAmericano(object sender, RoutedEventArgs e)
        {
            Drink americano = app.getDrinkByName("Americano");
            newInvoice.addOrder(americano);
            this.buttonAmericano.IsEnabled = false;
        }

        private void onClickedButtonIceTea(object sender, RoutedEventArgs e)
        {
            Drink iceTea = app.getDrinkByName("Ice Tea");
            newInvoice.addOrder(iceTea);
            this.buttonIceTea.IsEnabled = false;
        }

        private void onClickedButtonThaiTea(object sender, RoutedEventArgs e)
        {
            Drink thaiTea = app.getDrinkByName("Thai Tea");
            newInvoice.addOrder(thaiTea);
            this.buttonThaiTea.IsEnabled = false;
        }

        private void onClickedButtonCoffeLate(object sender, RoutedEventArgs e)
        {
            Drink coffeLate = app.getDrinkByName("Coffe Late");
            newInvoice.addOrder(coffeLate);
            this.buttonCoffeLate.IsEnabled = false;
        }

        private void onClickedButtonChocolatos(object sender, RoutedEventArgs e)
        {
            Drink chocolatos = app.getDrinkByName("Chocolatos");
            newInvoice.addOrder(chocolatos);
            this.buttonChocolatos.IsEnabled = false;
        }

        private void onClickedButtonLanjut(object sender, RoutedEventArgs e)
        {

            newCostumer.makeInvoice(newInvoice);

            if (!buttonCappucino.IsEnabled && !buttonAmericano.IsEnabled && !buttonChocolatos.IsEnabled && buttonIceTea.IsEnabled && buttonThaiTea.IsEnabled && buttonCoffeLate.IsEnabled)
            {
                 /*
                 * ===============================
                 *  CHECKPOINT 1 NILAI 40
                 * ===============================
                 *      -> User ngeklik menu cappucino, americano dan chocolatos
                 */
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Cappucino")));//seharusnya bernilai true
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Americano")));//seharusnya bernilai true
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Chocolatos")));//seharusnya bernilai true

                ConfirmationOrderWindow nextWindow = new ConfirmationOrderWindow();
                nextWindow.Show();
            }          
            else if (buttonCappucino.IsEnabled && buttonAmericano.IsEnabled && buttonCoffeLate.IsEnabled && buttonThaiTea.IsEnabled && buttonIceTea.IsEnabled && buttonChocolatos.IsEnabled)
            {
                /*
                   CHECKPOINT 2 NILAI 20
                   1. User seharusnya tidak bisa pindah ke halaman berikutnya jika tidak ada item yang dipilih
               */
                MessageBox.Show("Maaf! pesanan anda kosong");
            }
            else
            {
                /*
                 * ===============================
                 *  CHECKPOINT BONUS NILAI 50
                 * ===============================
                 *      -> User bisa memilih semua drink yang tersedia
                */
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Cappucino")));//seharusnya bernilai true
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Americano")));//seharusnya bernilai true
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Ice Tea")));//seharusnya bernilai true
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Thai Tea")));//seharusnya bernilai true
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Coffe Late")));//seharusnya bernilai true
                Console.WriteLine(newCostumer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Chocolatos")));//seharusnya bernilai true

                ConfirmationOrderWindow nextWindow = new ConfirmationOrderWindow();
                nextWindow.Show();
            }
            this.Close();
        }
            /*
            * ===============================
            *  CHECKPOINT BONUS NILAI 30
            * ===============================
            *      -> Button drink otomatis disable setelah dipilih
            */
    }
}
