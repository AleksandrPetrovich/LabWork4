using System.Collections.Generic;
using Port.Interfaces;

namespace Port.Model
{
    class Ship : IShip
    {
        public string Title { get; set; }
        public IPort Port { get; set; }
        public IRoute Route { get; set; }
        public List<IRoute> Routes { get; set; }
        public List<ICargo> Cargos { get; set; }
        public IFuel Fuel { get; set; }

        public void Send()
        {
            if (Route != null && Route.PortOfArrival != Port && Fuel != null)
            {
                Port.ShipDepartures(this);
                Route.AddPortOfDeparture(Port);
                Port = Route.PortOfArrival;
                Route.Cost(Fuel);
                Port.ShipArrives(this);
            }
        }        

        public void Load(ICargo cargo)
        {
            Cargos.Add(cargo);
        }

        public void Unload()
        {
            Cargos.Clear();
        }

        public void AddRoute(IRoute route)
        {
            Route = route;
        }

        public void RemoveRoute()
        {
            if (Route != null)
            {
                Routes.Add(Route);
                Route = null;
            }
        }

        public void Fill(IFuel fuel)
        {
            Fuel = fuel;
        }

        public Ship(string title, IPort port)
        {
            Title = title;
            Port = port;
            //Port.ShipArrives(this);
        }
    }
}
