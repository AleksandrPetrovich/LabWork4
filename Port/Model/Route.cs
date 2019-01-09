using System;
using Port.Interfaces;

namespace Port.Model
{
    [Serializable]
    public class Route : IRoute
    {
        public IPort Arrival { get; set; }
        public IPort Departure { get; set; }
        public double Costs { get; set; }
        public double Sums { get; set; }

        public void Cost(IFuel fuel)
        {
            Costs = Way() * fuel.Cost;
        }

        public double Way()
        {
            return Math.Abs(Arrival.Coordinate - Departure.Coordinate);
        }

        public void SetDeparture(IPort port)
        {
            Departure = port;
        }

        public void Sum(double sum)
        {
            Sums = sum;
        }

        public Route(IPort arrival)
        {
            Arrival = arrival;
        }
    }
}
