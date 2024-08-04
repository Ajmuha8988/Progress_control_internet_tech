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
	/// Логика взаимодействия для Window3.xaml
	/// </summary>
	public partial class Window3 : Window
	{
		public string fulname;
		public Window3()
		{
			
			//User authUser = null;

            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    authUser = db.Users.Where(b => b.email == email && b.password == pass).FirstOrDefault();
            //}
            InitializeComponent();
			ApplicationContext db = new ApplicationContext();
			List<Save> results = db.Saves.ToList();
			List<string> strings = results.Select(b => b.result).ToList();
			List<string> strings1 = results.Select(b => b.fullname).ToList();
			Listofusers.ItemsSource = results;



        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Punkt punkt = new Punkt();
			punkt.fulname = fulname;
			punkt.Show();
			Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Window1 window1 = new Window1();
			window1.fulname = fulname;
			window1.Show();
			Hide();
		}
	}
}
