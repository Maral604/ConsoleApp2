using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Memoryitem : ICalculator
    {
        private double sanasanToo;
        public Memoryitem(byte sanasanToo)
        {
            this.sanasanToo = sanasanToo;
        }
        public byte SanasanToo { get; }
        public void Add(double too)
        {
            this.sanasanToo += too;
        }
        public void Sub(double too)
        {
            this.sanasanToo -= too;
        }
        public void Clear()
        {
            this.sanasanToo = 0;
        }

    }

}
