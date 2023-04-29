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
using System.Windows.Shapes;

namespace Airport.Pages
{
    /// <summary>
    /// Логика взаимодействия для WindowFlightReservations.xaml
    /// </summary>
    public partial class WindowFlightReservations : Window
    {
        public WindowFlightReservations()
        {
            InitializeComponent();
            List<Flights> listFlights = BaseConnect.baseModel.Flights.ToList();
            List<string> nameFlights = new List<string>();
            foreach (Flights item in listFlights)
            {
                nameFlights.Add(item.FullNameFlights);
            }
            cbRoute.ItemsSource = nameFlights;

            List<Passangers> listPasseng = BaseConnect.baseModel.Passangers.ToList();
            List<string> namePAsseng = new List<string>();
            foreach (Passangers item in listPasseng)
            {
                namePAsseng.Add(item.FullNamePassanger);
            }
            cbPassanger.ItemsSource = namePAsseng;

            tbCountTicket.Text = "0";

            tbSumma.Text = "0 руб.";
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            BookedTickets bookedTickets = new BookedTickets();
            bookedTickets.ID_Flight = cbRoute.SelectedIndex + 1;
            bookedTickets.ID_Passanger = cbPassanger.SelectedIndex + 1;
            BaseConnect.baseModel.BookedTickets.Add(bookedTickets);
            BaseConnect.baseModel.SaveChanges();
            MessageBox.Show("Билет забронирован!");
            Close();
        }

        private void tbCountTicket_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (BaseConnect.baseModel.Flights.FirstOrDefault(x => x.ID_Flight == cbRoute.SelectedIndex + 1) != null && tbCountTicket.Text != "")
            {
                var c = tbCountTicket.Text;
                var a = Convert.ToDouble(tbCountTicket.Text);
                var b = Convert.ToDouble(BaseConnect.baseModel.Flights.FirstOrDefault(x => x.ID_Flight == (cbRoute.SelectedIndex + 1)).Price);
                tbSumma.Text = (Convert.ToDouble(tbCountTicket.Text) * Convert.ToDouble(BaseConnect.baseModel.Flights.FirstOrDefault(x => x.ID_Flight == (cbRoute.SelectedIndex + 1)).Price)).ToString() + " руб.";
            }
        }

        private void cbRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BaseConnect.baseModel.Flights.FirstOrDefault(x => x.ID_Flight == cbRoute.SelectedIndex + 1) != null && tbCountTicket.Text != "")
            {
                tbSumma.Text = (Convert.ToDouble(tbCountTicket.Text) * Convert.ToDouble(BaseConnect.baseModel.Flights.FirstOrDefault(x => x.ID_Flight == (cbRoute.SelectedIndex + 1)).Price)).ToString() + " руб.";
            }
        }
    }
}
