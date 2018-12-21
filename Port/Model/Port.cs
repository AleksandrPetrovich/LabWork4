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
            if (ship.Cargos.Count != 0)
            {                
                Thread.Sleep(500);
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
            Unload(ship);
        }

        public void ShipDepartures(IShip ship)
        {
            if (InPort.Contains(ship))
                InPort.Remove(ship);
        }

        public Port(string title, double coordinate)
        {
            Title = title;
            Coordinate = coordinate;
            InPort = new List<IShip>();
            OnUnloading = new List<IShip>();
        }

        public Port()
        {
            Title = "No name";
            Coordinate = 0;
            InPort = new List<IShip>();
            OnUnloading = new List<IShip>();
        }
    }
}
