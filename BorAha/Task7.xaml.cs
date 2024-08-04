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

namespace BorAha
{
    /// <summary>
    /// Логика взаимодействия для Task7.xaml
    /// </summary>
    public partial class Task7 : Page
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (answer.Text == "11010010.10101010.00011110.10000000")
            {
                score.Content = "Верно";
                score.Foreground = Brushes.Green;
            }
            else
            {
                score.Content = "Неверно";
                score.Foreground = Brushes.Red;
            }
        }
    }
}
