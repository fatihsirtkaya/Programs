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

            var mock = new Mock<IBusiness>();
            mock.Setup(x => x.CalculateFinalPosition("1 2 N" + Environment.NewLine + "LMLMLMLMM")).Returns("1 3 N");

            IBusiness business = new Business();
            Assert.AreEqual(business.CalculateFinalPosition("1 2 N" + Environment.NewLine + "LMLMLMLMM"), mock.Object.CalculateFinalPosition("1 2 N" + Environment.NewLine + "LMLMLMLMM"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var mock = new Mock<IBusiness>();
            mock.Setup(x => x.CalculateFinalPosition("3 3 E" + Environment.NewLine + "MMRMMRMRRM")).Returns("5 1 E");

            IBusiness business = new Business();
            Assert.AreEqual(business.CalculateFinalPosition("3 3 E" + Environment.NewLine + "MMRMMRMRRM"), mock.Object.CalculateFinalPosition("3 3 E" + Environment.NewLine + "MMRMMRMRRM"));

        }
    }
}
