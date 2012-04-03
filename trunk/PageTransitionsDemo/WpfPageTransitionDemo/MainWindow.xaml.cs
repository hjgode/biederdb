using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Threading.Tasks;
using System.Threading;
using WpfPageTransitions;

namespace WpfPageTransitionDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Stack<UserControl> pages = new Stack<UserControl>();

		public MainWindow()
		{
			InitializeComponent();

			cmbTransitionTypes.ItemsSource = Enum.GetNames(typeof(PageTransitionType));
		}

		private void btnNextPage_Click(object sender, RoutedEventArgs e)
		{
			NewPage newPage = new NewPage();

			pageTransitionControl.ShowPage(newPage);
		}

		private void cmbTransitionTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), cmbTransitionTypes.SelectedItem.ToString(), true);
		}		
	}
}
