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
    /// Логика взаимодействия для ComebackPhone.xaml
    /// </summary>
    public partial class ComebackPhone : Page
    {
        List<DB.Application> applications = DB.bd_connection.connection.Application.Where(p => p.Id_Client == ClientMainPage.mainClient.Id && p.Id_StatusAplication == 2).ToList();
        public ComebackPhone()
        {
            InitializeComponent();
            prod.ItemsSource= applications;
        }

        private void comebackBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new RefundWindow();
            window.Show();
            NavigationService.GoBack();
        }
    }
}
