using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.

            IOpticalDisc myCD = new CD(256, 25, true);

            myCD.SpinDisc();

            myCD.ReadData();

            myCD.WriteData(25);

            myCD.ReadData();

            IOpticalDisc myDVD = new DVD(256, 256, false);

            myDVD.SpinDisc();
            myDVD.ReadData();

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
