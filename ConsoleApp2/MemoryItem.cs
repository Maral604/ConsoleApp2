using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    public class Memoryitem : ICalculator
{
        public double SanasanToo { get; private set; }
        public Memoryitem(double sanasanToo)
        {
            this.SanasanToo = sanasanToo;
        }
        public void Add(double too)
        {
            this.SanasanToo += too;
        }
        public void Sub(double too)
        {
            this.SanasanToo -= too;
        }
        public void Clear()
        {
            this.SanasanToo = 0;
        }

    }

}


