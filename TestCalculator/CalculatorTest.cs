
using CalculatorLibrary;

namespace TestCalculator
{
    /// <summary>
    /// Тооны машины тестийг агуулсан класс.
    /// </summary>
    [TestClass]
    public sealed class CalculatorTest
    {
        /// <summary>
        /// Нэмэх үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void Add_TwoNumbers()
        {
            // 7 гэсэн анхны утгатай MainCalculator үүсгэнэ.
            MainCalculator calc = new MainCalculator(7);

            // 5-г нэмнэ.
            calc.Add(5);

            // Үр дүн 12 байх ёстой.
            Assert.IsTrue(calc.Result == 12);
        }

        /// <summary>
        /// Хасах үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void Sub_TwoNumbers()
        {
            // 6 гэсэн анхны утгатай MainCalculator үүсгэнэ.
            MainCalculator calc = new MainCalculator(6);

            // 4-г хасна.
            calc.Sub(4);

            // Үр дүн 2 байх ёстой.
            Assert.IsTrue(calc.Result == 2);
        }
    }
}
