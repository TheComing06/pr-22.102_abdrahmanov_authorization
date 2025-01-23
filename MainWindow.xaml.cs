using pr_22._102_abdrahmanov_authorization.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace pr_22._102_abdrahmanov_authorization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static SelectionEntities _context;
        public MainWindow()
        {
            InitializeComponent();
        }
        public static SelectionEntities GetContext()
        {
            if (_context == null)
            {
                _context = new SelectionEntities();
            }
            return _context;
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            
            SelectionEntities selection = GetContext();
            User user = new User();
            Role role = new Role();
            var realLog = user.UserName.ToString();
            string realPass = user.UserPassword.ToString();

            if (login == realLog && password == realPass)
            {
                MessageBox.Show($"Добро пожаловать! Ваша роль {user.Role.RoleName.ToString()}");
            }
            else
            {
                MessageBox.Show("Неверно введены логин или пароль!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            SelectionEntities selection = GetContext();
            MessageBox.Show($"{user.UserName.ToString()}");
        }
    }
}
