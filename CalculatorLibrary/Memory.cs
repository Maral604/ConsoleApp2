using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Memory
    {
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

        public void Save(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }
        public void Clear()
        {
            memoryItems.Clear();
        }

        public List<MemoryItem> GetAll()
        {
            return memoryItems;
        }
    }
}
