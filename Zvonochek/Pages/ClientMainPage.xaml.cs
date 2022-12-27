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
using Zvonochek.DB;
using Zvonochek.Windows;

namespace Zvonochek.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientMainPage.xaml
    /// </summary>
    public partial class ClientMainPage : Page
    {
        public static Client mainClient;
        List<Phone> phones = DB.bd_connection.connection.Phone.Where(p => p.Purchased == 0).ToList();
        public ClientMainPage()
        {
            InitializeComponent();
            prod.ItemsSource= phones;
        }

        private void RefundBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComebackPhone());
        }

        private void RepairBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new BuyWindows();
            window.Show();
        }
    }
}
