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
	/// Логика взаимодействия для Punkt.xaml
	/// </summary>
	public partial class Punkt : Window
	{
		public string fulname;
		public Punkt()
		{
			InitializeComponent();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Close();
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {

			Window1 window1 = new Window1();
			window1.fulname = fulname;
			window1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
			Window3 window = new Window3();
			window.fulname = fulname;
			window.Show();
			Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
			Task task = new Task();
			task.Show();
        }
    }
}
