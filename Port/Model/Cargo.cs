using Port.Interfaces;

namespace Port.Model
{
    class Cargo : ICargo
    {
        public double Cost { get; set; }

        public Cargo(double cost)
        {
            Cost = cost;
        }
    }
}
