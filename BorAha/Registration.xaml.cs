using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace BorAha
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        ApplicationContext db;
        Sign_in signIn = new Sign_in();
        public Registration()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }   

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Fullname = FIO.Text;
            string email = Email.Text;
            string pass = password.Password;
            string confpass = ConfirmPassword.Password;

            if(Fullname.Length < 10)
            {
                MessageBox.Show("Поле ФИО введено некоректно!");
                FIO.Background = Brushes.DarkRed;
                password.Background = Brushes.Transparent;
                ConfirmPassword.Background = Brushes.Transparent;
                Email.Background = Brushes.Transparent;
            }
            else if (pass.Length < 8)
            {
                MessageBox.Show("Длина пароля должна быть не менее 8!");
                password.Background = Brushes.DarkRed;
                FIO.Background = Brushes.Transparent;
                Email.Background = Brushes.Transparent;
                ConfirmPassword.Background = Brushes.Transparent;
            }
            else if (pass != confpass)
            {
                MessageBox.Show("Пароли не совпадают друг с другом!");
                ConfirmPassword.Background = Brushes.DarkRed;
                password.Background = Brushes.Transparent;
                FIO.Background = Brushes.Transparent;
                Email.Background = Brushes.Transparent;
            }
            else if (!email.Contains("@"))
            {
                MessageBox.Show("Некорректная почта!");
                Email.Background = Brushes.DarkRed;
                password.Background = Brushes.Transparent;
                FIO.Background = Brushes.Transparent;
                ConfirmPassword.Background = Brushes.Transparent;
            }
            else
            {
                signIn.Show();


                User user = new User(Fullname, email, pass);
                db.Users.Add(user);
                db.SaveChanges();
                Close();
            }
            
        }
    }
}
