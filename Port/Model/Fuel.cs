using System;
using Port.Interfaces;

namespace Port.Model
{
    [Serializable]
    public class Fuel : IFuel
    {
        public double Cost { get; set; }

        public Fuel()
        {
            Cost = 0;
        }

        public Fuel(double cost)
        {
            Cost = cost;
        }
    }
}
