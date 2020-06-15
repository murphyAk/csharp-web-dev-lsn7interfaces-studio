using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        bool Rewritable { get; }
        void SpinDisc();
        void ReadData();

        void WriteData(double data);
    }
}
