using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class BusinessWagon:PersonalWagon
    {
        Person steward;
        public BusinessWagon(int numberOfChairs,Person steward):base(numberOfChairs)
        {
            this.steward = steward;
        }
        public Person Steward { get => steward; set => steward = value; }
        public override string ToString() { return $"Business Wagon počet sedadel {NumberOfChairs} steward {steward.FirstName} {steward.LastName}"; }
    }
}
