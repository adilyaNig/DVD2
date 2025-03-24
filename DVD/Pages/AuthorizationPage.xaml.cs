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
using DVD.functions;
using DVD.Connection;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static Employee sotrudnik;

        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnV_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Capcha());
            int login = Convert.ToInt32(loginTb.Text.Trim());
            string password= ParolTb.Password.Trim();
            sotrudnik=Authorisation.AuthorisationSotr(login, password);
            if (sotrudnik != null)
            {
                MessageBox.Show("Ураа");
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void TbRegist_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new SignUpPage());
        }

        private void TbRegist_MouseEnter(object sender, MouseEventArgs e)
        {
            TbRegist.Foreground=new SolidColorBrush(Colors.Red);
        }

        private void TbRegist_MouseLeave(object sender, MouseEventArgs e)
        {
            TbRegist.Foreground = new SolidColorBrush(Colors.Black);
        }
    }
}
