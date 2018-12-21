using System;
using Port.Interfaces;

namespace Port.Model
{
    class Route : IRoute
    {
        public IPort PortOfArrival { get; set; }
        public IPort PortOfDeparture { get; set; }
        public double Costs { get; set; }
        public double Sums { get; set; }

        public void Cost(IFuel fuel)
        {
            Costs = Way() * fuel.Cost;
        }

        public double Way()
        {
            return Math.Abs(PortOfArrival.Coordinate - PortOfDeparture.Coordinate);
        }

        public void AddPortOfDeparture(IPort port)
        {
            PortOfDeparture = port;
        }

        public void Sum(double sum)
        {
            Sums = sum;
        }

        public Route(IPort portOfArrival)
        {
            PortOfArrival = portOfArrival;
        }
    }
}
