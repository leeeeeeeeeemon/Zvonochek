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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using Zvonochek.DB;
using Zvonochek.Pages;

namespace Zvonochek.Windows
{
    /// <summary>
    /// Логика взаимодействия для BuyWindows.xaml
    /// </summary>
    public partial class BuyWindows : Window
    {
        public BuyWindows()
        {
            InitializeComponent();
        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Application application = new DB.Application();
                application.Id_StatusAplication = 3;
                application.Id_Client = ClientMainPage.mainClient.Id;
                application.Id_Phone = Convert.ToInt32(idPhoneTB.Text);
                bd_connection.connection.Application.Add(application);
                Phone phone = bd_connection.connection.Phone.Where(x => x.Id == application.Id_Phone).FirstOrDefault();
                phone.Purchased = 1;
                bd_connection.connection.SaveChanges();
                MessageBox.Show("Успешная покупка");
                this.Close();
            } catch
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
            
        }
    }
}
