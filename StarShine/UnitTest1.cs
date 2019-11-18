using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StarShine
{
    [TestClass]
    public class UnitTest1
    {
        //NO CODING CHANGES TO DO HERE
        //DO NOT CHANGE ANY CODE IN THIS FILE
        [TestMethod]
        public void Test1()
        {
            double starShine = 7d;
            Star star = new Star(starShine);

            Assert.AreEqual(starShine, star.Shine());
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
    "A userId of null was inappropriately allowed.")]
        public void Test2()
        {
            double starShine = 7d;
            Star star = new Star(starShine);
            star.BlackHole();

            Assert.Equals(typeof(NullReferenceException), star.Shine());
        }
        [TestMethod]
        public void Test3()
        {
            Star star = new Star(12d);
            star.Name = "Sun";

            Assert.AreEqual("Sun", star.Name);
        }
    }
}
