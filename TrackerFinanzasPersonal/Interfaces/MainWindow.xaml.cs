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
using TrackerFinanzasPersonal.Interfaces;
using TrackerFinanzasPersonal.Interfaces.DetailPageInterfaces;

namespace TrackerFinanzasPersonal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DashboardPageView(object sender, RoutedEventArgs e)
        {
            DashboardPageButton.Visibility = Visibility.Visible;
            DetailPagesButton.Visibility = Visibility.Hidden;
            DashboardPage dashboard = new();
            DashboardPageButton.Children.Add(dashboard);
        }

        private void DetailPageView(object sender, RoutedEventArgs e)
        {
            DashboardPageButton.Visibility = Visibility.Hidden;
            DetailPagesButton.Visibility = Visibility.Visible;
            DetailPage detailPage = new();
            DetailPagesButton.Children.Add(detailPage);
            
        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}