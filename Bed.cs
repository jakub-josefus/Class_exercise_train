using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class Bed
    {
        int number;
        bool reserved;
        public Bed() { }
        public Bed(bool reserved)
        {
            this.reserved = reserved;
        }
        public Bed(int number, bool reserved)
        {
            this.number = number;
            this.reserved = reserved;
        }
    }
}
