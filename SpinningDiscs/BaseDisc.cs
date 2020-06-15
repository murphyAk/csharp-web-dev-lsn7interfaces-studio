using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public double Capacity { get; set; }

        public double StoredData { get; set; }
        public double AvailableData { get; set; }

        public bool Rewritable { get; set; }


        public BaseDisc(double capacity, double storedData, bool rewritable)
        {
            Capacity = capacity;
            StoredData = storedData;
            AvailableData = capacity - storedData;
            Rewritable = rewritable;
        }
        
    }
}
