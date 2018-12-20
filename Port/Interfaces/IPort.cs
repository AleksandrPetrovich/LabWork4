using System.Collections.Generic;

namespace Port.Interfaces
{
    interface IPort
    {
        string Title { get; set; }
        double Coordinate { get; set; }
        List<IShip> InPort { get; set; }
        List<IShip> OnUnloading { get; set; }

        void Unload(IShip ship);
        void ShipArrives(IShip ship);
        void ShipDepartures(IShip ship);
    }
}