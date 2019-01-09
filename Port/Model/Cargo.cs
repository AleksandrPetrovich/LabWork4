using System;
using Port.Interfaces;

namespace Port.Model
{
    [Serializable]
    public class Cargo : ICargo
    {
        public double Cost { get; set; }

        public Cargo()
        {
            Cost = 0;
        }

        public Cargo(double cost)
        {
            Cost = cost;
        }
    }
}
