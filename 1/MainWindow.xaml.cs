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

namespace _1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginInClick_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LoginBox.Text != null || PasswordBox.Text != null)
                {
                    var roleLoginIN = App.BD.Users.Where(r => r.Login == LoginBox.Text).FirstOrDefault();
                    if (roleLoginIN.Password == PasswordBox.Text)
                    {
                        if (roleLoginIN.IdRoles == 1)
                        {
                            LoginInNow.Now = roleLoginIN.Login;
                            AdminWindows adminWindowsLoginIn = new AdminWindows();
                            adminWindowsLoginIn.Show();
                            this.Close();
                        }
                        if (roleLoginIN.IdRoles == 2)
                        {
                            LoginInNow.Now = roleLoginIN.Login;
                            UsersWindows usersWindowsLoginIn = new UsersWindows();
                            usersWindowsLoginIn.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
