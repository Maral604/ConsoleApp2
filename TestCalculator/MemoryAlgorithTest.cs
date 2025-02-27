using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestCalculator
{
    /// <summary>
    /// Санах ойн нэмэх болон хасах үйлдлүүдийг шалгах тестийн класс.
    /// </summary>
    
    [TestClass]
    public class MemoryAlgorithTest
    {
        /// <summary>
        /// Санах ойн хадгалсан тоо дээр нэмэх болон хасах үйлдлүүдийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void Add_SubMemoryItem()
        {

            Memory memory = new Memory();
            Memoryitem savedItem = memory.Save(4);
            savedItem.Add(5);
            savedItem.Sub(7);
            Assert.AreEqual(1, memory.GetAll().Count);
            Assert.AreEqual(2, savedItem.SanasanToo);
        }
        [TestMethod]
        public void TestMemoryTotal()
        {
            Memory memory = new Memory();
            memory.Save(3);
            memory.Save(4);
            memory.Save(1);
             double total = 0;
            foreach (Memoryitem item in memory.memories)
            {
                total += item.SanasanToo;
            }
            Assert.AreEqual(total, 8);
        }


    }
}
