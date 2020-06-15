using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public bool Rewritable { get; set; }

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.


        public DVD(double capacity, double storedData, bool rewritable) : base(capacity, storedData, rewritable)
        {
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }

        public void ReadData()
        {
            Console.WriteLine($"{this.AvailableData}GB out of {this.Capacity}GB remaining");
        }

    }
}
