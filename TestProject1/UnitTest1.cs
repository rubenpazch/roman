using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roman;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Exercise.converRomanToInteger("I");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int result = Exercise.converRomanToInteger("II");
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int result = Exercise.converRomanToInteger("III");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int result = Exercise.converRomanToInteger("IV");
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int result = Exercise.converRomanToInteger("V");
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int result = Exercise.converRomanToInteger("VI");
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int result = Exercise.converRomanToInteger("VII");
            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int result = Exercise.converRomanToInteger("VIII");
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int result = Exercise.converRomanToInteger("IX");
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void TestMethod10()
        {
            int result = Exercise.converRomanToInteger("X");
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void TestMethod11()
        {
            int result = Exercise.converRomanToInteger("XI");
            Assert.AreEqual(11, result);
        }
        [TestMethod]
        public void TestMethod12()
        {
            int result = Exercise.converRomanToInteger("XV");
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void TestMethod13()
        {
            int result = Exercise.converRomanToInteger("IXX");
            Assert.AreEqual(19, result);
        }
        [TestMethod]
        public void TestMethod14()
        {
            int result = Exercise.converRomanToInteger("XXI");
            Assert.AreEqual(21, result);
        }
        [TestMethod]
        public void TestMethod15()
        {
            int result = Exercise.converRomanToInteger("XXXI");
            Assert.AreEqual(31, result);
        }
        [TestMethod]
        public void TestMethod16()
        {
            int result = Exercise.converRomanToInteger("XXXIV");
            Assert.AreEqual(34, result);
        }
        [TestMethod]
        public void TestMethod17()
        {
            int result = Exercise.converRomanToInteger("LVIII");
            Assert.AreEqual(58, result);
        }
        [TestMethod]
        public void TestMethod18()
        {
            int result = Exercise.converRomanToInteger("MCMXCIV");
            Assert.AreEqual(1994, result);
        }
        
    }
}
