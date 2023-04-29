using Airport.StaticClasses;
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

namespace Airport.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageFlights.xaml
    /// </summary>
    public partial class PageFlights : Page
    {
        public PageFlights()
        {
            InitializeComponent();
            dgFlights.ItemsSource = BaseConnect.baseModel.Flights.ToList();
            
            
        }

        private void btnSaveChange_Click(object sender, RoutedEventArgs e)
        {
            BaseConnect.baseModel.SaveChanges();
        }

        private void btnBooked_Click(object sender, RoutedEventArgs e)
        {
            WindowFlightReservations window = new WindowFlightReservations();
            window.ShowDialog();

        }

        private void cbRoutes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int id = (int)comboBox.Tag;
            Routes routes = BaseConnect.baseModel.Routes.FirstOrDefault(x => x.ID_Route == id);
            routes.ID_Route = comboBox.SelectedIndex + 1;
        }
    }
}
