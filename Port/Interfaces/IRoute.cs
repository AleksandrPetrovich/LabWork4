namespace Port.Interfaces
{
    public interface IRoute
    {
        IPort Arrival { get; set; }
        IPort Departure { get; set; }
        double Costs { get; set; }
        double Sums { get; set; }

        double Way();
        void Sum(double sum);
        void Cost(IFuel fuel);
        void SetDeparture(IPort port);
    }
}