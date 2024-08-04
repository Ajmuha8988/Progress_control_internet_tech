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
    /// Логика взаимодействия для Task8.xaml
    /// </summary>
    public partial class Task8 : Page
    {
        public Task8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (answer.Text == "215.32.56.182")
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
