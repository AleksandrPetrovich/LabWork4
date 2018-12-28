using System.Collections.Generic;

namespace Port.Interfaces
{
    public interface IShip
    {
        string Title { get; set; }
        IPort Port { get; set; }
        IFuel Fuel { get; set; }
        IRoute Route { get; set; }
        ICollection<IRoute> Routes { get; set; }
        ICollection<ICargo> Cargos { get; set; }        

        void Load(ICargo cargo);
        void Unload();
        void Send();        
        void SetRoute(IRoute route);
        void RemoveRoute();
        void Fill(IFuel fuel);
        bool Ready();
    }
}