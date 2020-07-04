using HepsiBurada;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;
using System;

namespace UnitTestHepsiBurada
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var mock = new Mock<ICalculate>();
            mock.Setup(x => x.CalculateFinalPosition("1 2 N" , "LMLMLMLMM")).Returns("1 3 N");

            ICalculate business = new Calculate();
            Assert.AreEqual(business.CalculateFinalPosition("1 2 N" , "LMLMLMLMM"), mock.Object.CalculateFinalPosition("1 2 N", "LMLMLMLMM"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var mock = new Mock<ICalculate>();
            mock.Setup(x => x.CalculateFinalPosition("3 3 E" , "MMRMMRMRRM")).Returns("5 1 E");

            ICalculate business = new Calculate();
            Assert.AreEqual(business.CalculateFinalPosition("3 3 E" , "MMRMMRMRRM"), mock.Object.CalculateFinalPosition("3 3 E" , "MMRMMRMRRM"));

        }
    }
}
