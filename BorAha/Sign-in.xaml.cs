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

namespace BorAha
{
    /// <summary>
    /// Логика взаимодействия для Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Window
    {
        Punkt punkt1 = new Punkt();
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = Email.Text;
            string pass = password.Password;
            if (!email.Contains("@"))
            {
                MessageBox.Show("Некорректная почта!");
                Email.Background = Brushes.DarkRed;
            }
            else
            {
            
               User authUser = null;
            
                using (ApplicationContext db = new ApplicationContext())
                {
                   authUser = db.Users.Where(b => b.email == email && b.password == pass).FirstOrDefault();
                }
            
                if(authUser != null)
                {
                    punkt1.fulname = authUser.fullname;
                    punkt1.Show();
                    Close();
                    
                }
                else
                {
                   MessageBox.Show("Вы ввели неправильную почту или пароль!");
                }
            
            }
        }
    }
}
