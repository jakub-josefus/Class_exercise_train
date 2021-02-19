﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class Chair
    {
        int number = 0;
        bool nearWindow=true;
        bool reserved=true;
        public Chair() { }
        public Chair(int number, bool nearWindow,bool reserved)
        {
            this.number = number;
            this.nearWindow = nearWindow;
            this.reserved = reserved;
        }
        public int Number { get => number; set => number = value; }
        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
    }
}
