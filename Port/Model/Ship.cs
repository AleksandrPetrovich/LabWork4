using System;
using System.Collections.Generic;
using System.Linq;
using Port.Interfaces;

namespace Port.Model
{
    public class Ship : IShip
    {
        public string Title { get; set; }
        public IPort Port { get; set; }
        public IRoute Route { get; set; }
        public ICollection<IRoute> Routes { get; set; }
        public ICollection<ICargo> Cargos { get; set; }
        public IFuel Fuel { get; set; }

        public void Send()
        {
            if (Ready())
            {
                Port.ShipDepartures(this);
                Route.SetDeparture(Port);
                Port = Route.Arrival;
                Route.Cost(Fuel);
                Port.ShipArrives(this);
            }
            else
            {
                throw new InvalidOperationException("Корабль не готов к отплытию!");
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

        public void SetRoute(IRoute route)
        {
            Route = route;
        }

        public void RemoveRoute()
        {
            if (Route != null)
            {
                Route.Sum((from cargo in Cargos select cargo.Cost).Sum());
                Routes.Add(Route);
                Route = null;
            }
        }

        public void Fill(IFuel fuel)
        {
            Fuel = fuel;
        }

        public bool Ready()
        {
            return Route != null && Route.Arrival != Port && Fuel != null;
        }

        public Ship(string title, IPort port)
        {
            Title = title;
            Port = port;
            Routes = new List<IRoute>();
            Cargos = new List<ICargo>();
            Port.ShipArrives(this);
        }
    }
}
