using System;
using NUnit;
using NUnit.Framework;
using LeraCute;

namespace TestProj
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMessage()
        {
            Lera lera = new Lera("msg");

            Assert.AreEqual("msg", lera.GetMessage());
        }
    }
}
