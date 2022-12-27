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
using Zvonochek.DB;

namespace Zvonochek.Windows
{
    /// <summary>
    /// Логика взаимодействия для RefundWindow.xaml
    /// </summary>
    public partial class RefundWindow : Window
    {
        public RefundWindow()
        {
            InitializeComponent();
        }

        private void RefBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idAppTB.Text);
                DB.Application application = bd_connection.connection.Application.Where(p => p.Id == id).FirstOrDefault();
                application.Id_StatusAplication = 4;
                MessageBox.Show("Успешный возврат");
                Phone phone = bd_connection.connection.Phone.Where(x => x.Id == application.Id_Phone).FirstOrDefault();
                phone.Purchased = 0;
                bd_connection.connection.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Не верно введенны данные!");
            }
            

        }
    }
}
