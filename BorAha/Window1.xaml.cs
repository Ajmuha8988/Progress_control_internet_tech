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
	/// Логика взаимодействия для Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public string fulname;
        int ball;
        int score;
		public Window1()
		{
			InitializeComponent();
			


		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if((T1.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
				
			}
			if ((T2.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
			}
			if ((T3.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
			}
			if ((T4.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
			}
			if ((T5.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
			}
			if ((T6.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
			}
			if ((T7.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
			}
			if ((T8.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
			}
			if ((T9.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
			}
			if ((T10.IsChecked == true))
			{
				ball += 1;
				count.Content = ball;
				
			}
            if ((T11.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;

            }
            if ((T12.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;
            }
            if ((T13.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;
            }
            if ((T14.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;
            }
            if ((T15.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;
            }
            if ((T16.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;
            }
            if ((T17.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;
            }
            if ((T18.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;
            }
            if ((T19.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;
            }
            if ((T20.IsChecked == true))
            {
                ball += 1;
                count.Content = ball;

            }
            if (ball == 20)
			{
				score = 5;
                Window2 window2 = new Window2();
                window2.fulname = fulname;
                window2.Result.Content = score;
                window2.abc = score;
                window2.Show();
                Hide();
            }
            if (ball > 14 && ball < 20)
            {
                score = 4;
                Window2 window2 = new Window2();
                window2.fulname = fulname;
                window2.Result.Content = score;
                window2.abc = score;
                window2.Show();
                Hide();
            }
            if (ball > 10 && ball < 14)
            {
                score = 3;
                Window2 window2 = new Window2();
                window2.fulname = fulname;
                window2.Result.Content = score;
                window2.abc = score;
                window2.Show();
                Hide();
            }
            if (ball > 4 && ball < 10)
            {
                score = 2;
                Window2 window2 = new Window2();
                window2.fulname = fulname;
                window2.Result.Content = score;
                window2.abc = score;
                window2.Show();
                Hide();
            }
            if(ball > 0 && ball < 4)
            {
                score = 1;
                Window2 window2 = new Window2();
                window2.fulname = fulname;
                window2.Result.Content = score;
                window2.abc = score;
                window2.Show();
                Hide();
            }

        }
	}
}
