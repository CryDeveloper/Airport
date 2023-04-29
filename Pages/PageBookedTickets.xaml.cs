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
    /// Логика взаимодействия для PageBookedTickets.xaml
    /// </summary>
    public partial class PageBookedTickets : Page
    {
        public PageBookedTickets()
        {
            InitializeComponent();
            dgBookedTickets.ItemsSource = BaseConnect.baseModel.BookedTickets.ToList();
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
    }
}
