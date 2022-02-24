using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork1;
namespace RomanNumbersUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]    
        public void TestToString()
        {
            var number = new RomanNumber(10);
            Assert.AreEqual("X", number.ToString());
        }
        
        [TestMethod]
        public void TestClone()
        {
            var number = new RomanNumber(10);
            RomanNumber number2 = (RomanNumber) number.Clone();
            Assert.IsTrue(number.CompareTo(number2) == 0);
        }
        
        [TestMethod]
        public void TestAdd()
        {
            var n1 = new RomanNumber(11);
            var n2 = new RomanNumber(43);
            var expected = new RomanNumber(11 + 43);
            var res = n1 + n2;
            Assert.IsTrue(res.CompareTo(expected) == 0);
        }
        
        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestSub1()
        {
            var n1 = new RomanNumber(11);
            var n2 = new RomanNumber(43);
            var res = n1 - n2;

        }
        
        [TestMethod]
        public void TestSub2()
        {
            var n1 = new RomanNumber(43);
            var n2 = new RomanNumber(11);
            Assert.IsTrue(
                (n1 - n2).CompareTo(new RomanNumber(43 - 11)) == 0
                );
            
        }
        [TestMethod]
        public void TestMul1()
        {
            var n1 = new RomanNumber(2);
            var n2 = new RomanNumber(10);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(2 * 10)) == 0
            );
            
        }
        [TestMethod]
        public void TestMul2()
        {
            var n1 = new RomanNumber(232);
            var n2 = new RomanNumber(12);
            Assert.IsTrue(
                (n1 * n2).CompareTo(new RomanNumber(232 * 12)) == 0
            );
            
        }
        [TestMethod]
        public void TestDiv1()
        {
            var n1 = new RomanNumber(232);
            var n2 = new RomanNumber(12);
            Assert.IsTrue(
                (n1 / n2).CompareTo(new RomanNumber(232 / 12)) == 0
            );
        }
        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void TestDiv2()
        {
            var n1 = new RomanNumber(232);
            var n2 = new RomanNumber(312);
            Assert.IsTrue(
                (n1 / n2).CompareTo(new RomanNumber(232 / 312)) == 0
            );
        }
        
    }
}