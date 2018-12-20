namespace Port.Interfaces
{
    interface IRoute
    {
        IPort PortOfArrival { get; set; }
        IPort PortOfDeparture { get; set; }
        double Costs { get; set; }

        double Way();
        void Cost(IFuel fuel);
        void AddPortOfDeparture(IPort port);
    }
}