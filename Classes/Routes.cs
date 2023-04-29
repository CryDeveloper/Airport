using Airport.StaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public partial class Routes
    {
        public string FullRoute
        {
            get => DeparturePoint + " - " + Destination;
            set
            {
                var a = value;
            }
        }
        
    }


    public partial class Flights
    {
        public string FullNameFlights => (Routes.FullRoute + " " + Number_Flight + " " + ClassesFlights.NAmeClasses).ToString();

        public List<string> AllRoutes 
        { 
            get
            {
                List<Routes> routes = BaseConnect.baseModel.Routes.ToList();
                List<string> result = new List<string>();
                foreach (Routes item in routes)
                {
                    result.Add(item.FullRoute);
                }
                return result;
            }
        }
    }

    public partial class Passangers
    {
        public string FullNamePassanger => (Surname + " " + Name + " " + Patronymic + " " + SerialrDocument + " " + NumberDocument).ToString();
    }
}
