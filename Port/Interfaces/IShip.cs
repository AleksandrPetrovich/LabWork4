using System.Collections.Generic;

namespace Port.Interfaces
{
    interface IShip
    {
        string Title { get; set; }
        IPort Port { get; set; }
        IFuel Fuel { get; set; }
        IRoute Route { get; set; }
        List<IRoute> Routes { get; set; }
        List<ICargo> Cargos { get; set; }        

        void Load(ICargo cargo);
        void Unload();
        void Send();        
        void AddRoute(IRoute route);
        void RemoveRoute();
        void Fill(IFuel fuel);
        bool Ready();
    }
}