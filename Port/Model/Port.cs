using System.Collections.Generic;
using System.Threading;
using Port.Interfaces;

namespace Port.Model
{
    class Port : IPort
    {
        public string Title { get; set; }
        public double Coordinate { get; set; }
        public List<IShip> InPort { get; set; }
        public List<IShip> OnUnloading { get; set; }

        public void Unload(IShip ship)
        {
            if (ship.Cargos != null)
            {
               Thread.Sleep(5000);
                ship.Unload();
            }
            if (OnUnloading.Contains(ship))
            {
                OnUnloading.Remove(ship);
            }
            InPort.Add(ship);
        }

        public void ShipArrives(IShip ship)
        {
            OnUnloading.Add(ship);
            ship.RemoveRoute();
        }

        public void ShipDepartures(IShip ship)
        {
            if (InPort.Contains(ship))
                InPort.Remove(ship);
        }

        public Port (string title, double coordinate)
        {
            Title = title;
            Coordinate = coordinate;
        }
    }
}
