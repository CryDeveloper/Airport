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
using Airport.StaticClasses;
using Airport.Pages;

namespace Airport
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.ActiveFrame = frame;
            MainFrame.ActiveFrame.Navigate(new PageFlights());
        }

        private void btnFlights_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.ActiveFrame.Navigate(new PageFlights());
        }

        private void btnPassangers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.ActiveFrame.Navigate(new PagePassangers());
        }

        private void btnRoutes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.ActiveFrame.Navigate(new PageRoutes());
        }
        private void btnPlane_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.ActiveFrame.Navigate(new PagePlanes());
        }

        private void btnBoked_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.ActiveFrame.Navigate(new PageBookedTickets());
        }

    }
}
