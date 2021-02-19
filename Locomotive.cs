using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class Locomotive
    {
        Person driver;
        Engine engine;
        public Locomotive() { }

        public Locomotive(Person driver, Engine engine)
        {
            this.driver = driver;
            this.engine = engine;
        }
        internal Person Driver { get => driver; set => driver = value; }
        internal Engine Engine { get => engine; set => engine = value; }
        public override string ToString() { return "Locomotive"; }
    }
}
