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

namespace _1
{
    /// <summary>
    /// Логика взаимодействия для AdminWindows.xaml
    /// </summary>
    public partial class AdminWindows : Window
    {
        public AdminWindows()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            var ListUsersShow = App.BD.Users.ToList();
            Users userdDBShow = new Users();
            var SearchUsers = SearchBox.Text;
            if (SearchUsers != "")
            {
                ListUsersShow = App.BD.Users.Where(s => s.Name.StartsWith(SearchUsers)).ToList();
            }
            ListUserView.ItemsSource = ListUsersShow;      
        }
        private void AddUserClick_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users
            {
                Name = UserNameBox.Text,
                Surname = UserSurnameBox.Text,
                Patronimyc = UserPatronimycBox.Text,
                Login = LoginUsersBox.Text,
                Password = PasswordUsersBox.Text,
            };
            App.BD.Users.Add(users);
            App.BD.SaveChanges();
            Update();
        }
        private void DeleteUserClick_Click(object sender, RoutedEventArgs e)
        {
            Button DeleteClick = (Button)sender;
            Users usersDelete = (Users)DeleteClick.DataContext;
            App.BD.Users.Remove(usersDelete);
            App.BD.SaveChanges();
            Update();
        }

        private void EditUsersClick_Click(object sender, RoutedEventArgs e)
        {
            Button EditClick = (Button)sender;
            Users usersEdit = (Users)EditClick.DataContext;
            UserNameBox.Text = usersEdit.Name;
            UserSurnameBox.Text = usersEdit.Surname;
            UserPatronimycBox.Text = usersEdit.Patronimyc;
            LoginUsersBox.Text = usersEdit.Login;
            PasswordUsersBox.Text = usersEdit.Password;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
    }
}
