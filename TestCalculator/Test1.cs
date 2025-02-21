using CalculatorLibrary;

namespace TestCalculator
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Add_TwoNumbers()
        {

            MainCalculator calc = new MainCalculator();
            calc.Result = 5;
            double result = calc.Add(3); 

            Assert.IsTrue(calc.Result==8);
        }

        [TestMethod]
        public void Sub_TwoNumbers()
        {

            MainCalculator calc = new MainCalculator();

            calc.Result = 6;
            double result = calc.Sub(4);
            Assert.IsTrue(calc.Result == 2);

        }

    }
}

