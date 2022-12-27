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

namespace Zvonochek.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        List<Client> clients = bd_connection.connection.Client.ToList();
        List<Employe> employes = bd_connection.connection.Employe.ToList();
        public AuthPage()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if(loginTB.Text == "" || PasswordTB.Password == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            Client client = bd_connection.connection.Client.Where(c => c.Login == loginTB.Text && c.Password == PasswordTB.Password).FirstOrDefault();
            if(client != null)
            {
                ClientMainPage.mainClient= client;
                NavigationService.Navigate(new ClientMainPage());
                return;
            }
            Employe employe = bd_connection.connection.Employe.Where(c => c.Login == loginTB.Text && c.Password == PasswordTB.Password).FirstOrDefault();
            if(employe != null)
            {

            }
            MessageBox.Show("Пользователь не найден");
            return;
        }
    }
}
