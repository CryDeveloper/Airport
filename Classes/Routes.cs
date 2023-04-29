using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public partial class Routes
    {
        public string FullRoute => DeparturePoint + " - " + Destination;
    }


    public partial class Flights
    {
        public string FullNameFlights => (Routes.FullRoute + " " + Number_Flight + " " + ClassesFlights.NAmeClasses).ToString();
    }

    public partial class Passangers
    {
        public string FullNamePassanger => (Surname + " " + Name + " " + Patronymic + " " + SerialrDocument + " " + NumberDocument).ToString();
    }
}
