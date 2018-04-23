using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPLABA3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        double[] test1 = { 0, 1, 2 };
        double[] test2 = { 1, 2, 3 };

        double[] t1 = { 0, 3, 9 };
        double[] t2 = { 24, 6, 12 };

        double[] te1 = { 0, 2, 3 };
        double[] te2 = { 1, 3, 4 };

        double out1 = 3;
        double out2 = 24;
        double out3 = 3;

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(out1, Program.CreateX(test1, test2), 0.01);
            Assert.AreEqual(out1, Program.CreateX(test1, test2), 0.01);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(out2, Program.CreateX(t1, t2), 0.01);
            Assert.AreEqual(out2, Program.CreateX(t1, t2), 0.01);
        }

        [TestMethod]
        public void TestMetod3()
        {
            Assert.AreEqual(out3, Program.CreateX(te1, te2), 0.01);
            Assert.AreEqual(out3, Program.CreateX(te1, te2), 0.01);
        }
    }
}