using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class Hopper:IWagons
    {
        double loadingCapacity;
        public Hopper() { }
        public Hopper(double loadingCapacity)
        {
            this.loadingCapacity = loadingCapacity;
        }

        public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }

        public override string ToString() { return $"Hopper kapacita nakladu {loadingCapacity}"; }
    }
}
