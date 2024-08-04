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
    /// Логика взаимодействия для Task.xaml
    /// </summary>
    public partial class Task : Window
    {
        public int page = 1;
        public Task()
        {
            InitializeComponent();
            if(page == 1)
            {
                bt1.IsEnabled = false;
            }
            main.Content = new Task1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            page++;
            number.Content = page;
            if(page == 2)
            {
                main.Content = new Task2();
                bt1.IsEnabled = true;

            }
            if (page == 3)
            {
                main.Content = new Task3();
                bt1.IsEnabled = true;

            }
            if (page == 4)
            {
                main.Content = new Task4();
                bt1.IsEnabled = true;

            }
            if (page == 5)
            {
                main.Content = new Task5();
                bt1.IsEnabled = true;

            }
            if (page == 6)
            {
                main.Content = new Task6();
                bt1.IsEnabled = true;

            }
            if (page == 7)
            {
                main.Content = new Task7();
                bt1.IsEnabled = true;

            }
            if (page == 8)
            {
                main.Content = new Task8();
                bt1.IsEnabled = true;

            }
            if (page == 9)
            {
                main.Content = new Task9();
                bt1.IsEnabled = true;

            }
            if (page == 10)
            {
                bt2.IsEnabled = false;
                main.Content = new Task10();
            }
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            page--;
            number.Content = page;
            if(page == 9)
            {
                bt2.IsEnabled = true;
                main.Content = new Task9();
            }
            if (page == 8)
            {
                bt2.IsEnabled = true;
                main.Content = new Task8();
            }
            if (page == 7)
            {
                bt2.IsEnabled = true; 
                main.Content = new Task7();
            }
            if (page == 6)
            {
                bt2.IsEnabled = true;
                main.Content = new Task6();
            }
            if (page == 5)
            {
                bt2.IsEnabled = true;
                main.Content = new Task5();
            }
            if (page == 4)
            {
                bt2.IsEnabled = true;
                main.Content = new Task4();
            }
            if (page == 3)
            {
                main.Content = new Task3();
                bt1.IsEnabled = true;

            }
            if (page == 2)
            {
                main.Content = new Task2();
                bt1.IsEnabled = true;

            }
            if (page == 1)
            {
                main.Content = new Task1();
                bt1.IsEnabled = false;
            }
            
        }

    }
}
