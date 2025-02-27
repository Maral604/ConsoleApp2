using System;
using CalculatorLibrary;

namespace Calculator
{
   public class Program
    {
        static void Main(string[] args)
        {
            MainCalculator calc = new MainCalculator();
            Memory memory = new Memory();

            calc.Result = double.Parse(Console.ReadLine());

            calc.Add(10);
            calc.Sub(5);
            Console.WriteLine($"+10-5= {calc.Result}");

            Memoryitem savedItem = memory.Save(calc.Result);
            Console.WriteLine("Saved: " + savedItem.SanasanToo);

            savedItem.Add(5);
            Console.WriteLine("+5 memory: " + savedItem.SanasanToo);

            List<Memoryitem> allMemories = memory.GetAll();
            Console.WriteLine("Memory:");
            foreach (var item in allMemories)
            {
                Console.WriteLine(item.SanasanToo);
            }
            memory.Clear();
        }
    }
}
