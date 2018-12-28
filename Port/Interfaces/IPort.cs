using System.Collections.Generic;

namespace Port.Interfaces
{
    public interface IPort
    {
        string Title { get; set; }
        double Coordinate { get; set; }
        ICollection<IShip> InPort { get; set; }
        ICollection<IShip> OnUnloading { get; set; }

        void Unload(IShip ship);
        void ShipArrives(IShip ship);
        void ShipDepartures(IShip ship);
    }
}