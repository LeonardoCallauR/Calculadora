using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiCalculadora.Controllers;

namespace UTCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddGet1()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int NumA = 3;
            int NumB = 4;
            int NumC = 7;
            //Act
            int result = calc.Add(NumA, NumB);
            //Aaaee
            Assert.AreEqual(NumC, result);
        }
        [TestMethod]
        public void TestAddGet2()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int NumA = -3;
            int NumB = -4;
            int NumC = -7;
            //Act
            int result = calc.Add(NumA, NumB);
            //Aaaee
            Assert.AreEqual(NumC, result);
        }
        [TestMethod]
        public void TestAddMultiply1()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int NumA = 3;
            int NumB = 4;
            int NumC = 12;
            //Act
            int result = calc.Multiply(NumA, NumB);
            //Aaaee
            Assert.AreEqual(NumC, result);
        }
        [TestMethod]
        public void TestAddMultiply2()
        {
            //Arrange
            CalculatorController calc = new CalculatorController();
            int NumA = -3;
            int NumB = 4;
            int NumC = -12;
            //Act
            int result = calc.Multiply(NumA, NumB);
            //Aaaee
            Assert.AreEqual(NumC, result);
        }
    }
}
