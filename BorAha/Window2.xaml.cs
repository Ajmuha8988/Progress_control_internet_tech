using System;
using System.Collections.Generic;
using System.Configuration;
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
	
	public partial class Window2 : Window
	{
		public string fulname;
        public int abc;
		ApplicationContext db;
		public Window2()
		{
			db = new ApplicationContext();

			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string res = abc.ToString();
			Save result = new Save(fulname ,res);
			db.Saves.Add(result);
			db.SaveChanges();
			Window3 window3 = new Window3();
			window3.fulname = fulname;
			window3.Show();
			Close();
		}
	}
}
