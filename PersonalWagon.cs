using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    abstract class PersonalWagon:IWagons
    {
        List<Door> doors;
        Chair[] chairs;
        int numberOfChairs;
        public PersonalWagon()
        {

        }
        public PersonalWagon(int numberOfChairs)
        {
            this.numberOfChairs = numberOfChairs;
            chairs = new Chair[numberOfChairs+1];
            for (int i = 1; i < chairs.Length; i++)
            {
                chairs[i] = new Chair();
                chairs[i].Number = i;
            }
        }
        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        internal List<Door> Doors { get => doors; set => doors = value; }
        internal Chair[] Chairs { get => chairs; set => chairs = value; }

        public override string ToString() { return ""; }
    }
}
