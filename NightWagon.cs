using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class NightWagon:PersonalWagon
    {
        Bed[] beds;
        int numberOfBeds;
        public NightWagon(int numberOfChairs,int numberOfBeds):base(numberOfChairs)
        {
            this.numberOfBeds = numberOfBeds;
            beds =new Bed[numberOfBeds];
        }
        public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }
        internal Bed[] Beds { get => beds; set => beds = value; }

        public override string ToString() { return $"Night Wagon počet sedadel {NumberOfChairs} počet postele {numberOfBeds}"; }
    }
}
