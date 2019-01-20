using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Port.Model;
using Port.Interfaces;

namespace Port.View
{
    public sealed class MainFormViewModel : INotifyPropertyChanged
    {
        private IShip _ship;

        public event PropertyChangedEventHandler PropertyChanged;
        
        public ICollection<Model.Port> PortList { get; } = new List<Model.Port>();
        public ICollection<Ship> ShipList { get; } = new List<Ship>();
        public ICollection<Route> RouteList { get; } = new List<Route>();
        public ICollection<Fuel> FuelList { get; } = new List<Fuel>();
        public ICollection<Cargo> CargoList { get; } = new List<Cargo>();

        public IShip Ship
        {
            get => _ship;
            set
            {
                _ship = value;
                OnPropertyChanged(nameof(Ship));                
            }
        }

        public void CreatePort(string title, double coordinate)
        {
            PortList.Add(new Model.Port(title, coordinate));
            OnPropertyChanged(nameof(Ship));
        }

        public void CreateRoute(IPort arrival)
        {
            RouteList.Add(new Route(arrival));
        }

        public void CreateFuel(double cost)
        {
            FuelList.Add(new Fuel(cost));
        }

        public void CreateCargo(double cost)
        {
            CargoList.Add(new Cargo(cost));
        }

        public void CreateShip(string title, IPort port)
        {
            ShipList.Add(new Ship(title, port));
            OnPropertyChanged(nameof(Ship));
        }

        public void FillShip(IFuel fuel)
        {
            Ship.Fill(fuel);
        }

        public void LoadShip(ICargo cargo)
        {
            Ship.Load(cargo);
        }

        public void SetRoute(IRoute route)
        {
            Ship.SetRoute(route);
        }

        public void Send()
        {
            Ship.Send();
            OnPropertyChanged(nameof(Ship));
        }
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}