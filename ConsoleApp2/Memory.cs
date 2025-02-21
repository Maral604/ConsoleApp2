using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Memory
    {
        public List<Memoryitem> memories = new List<Memoryitem>();
        public Memoryitem Save(double too)
        {
            Memoryitem item = new Memoryitem(too);
            memories.Add(item);
            return item;

        }
        public List<Memoryitem> GetAll()
        {
            return memories;
        }
        public void Clear()
        {
            memories.Clear();
        }

    }
}
