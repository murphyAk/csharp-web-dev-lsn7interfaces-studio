using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 


        public CD(double capacity, double storedData, bool rewritable) : base(capacity, storedData, rewritable)
        {
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm");
        }
        public void ReadData()
        {
            Console.WriteLine($"{this.AvailableData}GB out of {this.Capacity}GB remaining");
        }

        public void WriteData(double dataSize)
        {
            Console.WriteLine("rewrite");
            AvailableData -= dataSize;
        }
    }
}
