using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class EconomyWagon:PersonalWagon
    {
        public EconomyWagon(int numberOfChairs):base(numberOfChairs)
        {
        }
        public override string ToString() { return $"Economy Wagon počet sedadel {NumberOfChairs}"; }
    }
}
