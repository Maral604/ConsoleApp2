using System;


namespace Calculator
{
   public class Program
    {
        static void Main(string[] args)
        {
            MainCalculator calc = new MainCalculator();

            Memory memory = new Memory();

            calc.Add(10);
            Console.WriteLine($"+10= {calc.Result}");

            calc.Sub(5);
            Console.WriteLine($"-5=: {calc.Result}");

            memory.Save(calc.Result);
            Console.WriteLine("Memory-d hadgalagdlaa.");

            Console.WriteLine("Memory:");
            foreach (var item in memory.GetAll())
            {
                Console.WriteLine(item.Value);
            }
            memory.Clear();
        }
    }
}
