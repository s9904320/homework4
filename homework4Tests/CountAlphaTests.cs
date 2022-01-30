using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4.Tests
{
    [TestClass()]
    public class CountAlphaTests
    {
        [TestMethod()]
        public void CountAlphaForNullOrEmpty()
        {
            Assert.AreEqual(0, CountAlpha.CountAlphaFunction(""));
            Assert.AreEqual(0, CountAlpha.CountAlphaFunction(null));
        }

        [TestMethod()]
        public void CountAlphaForNormal()
        {
            Assert.AreEqual(0, CountAlpha.CountAlphaFunction("abcde"));
            Assert.AreEqual(2, CountAlpha.CountAlphaFunction("aabbcde"));
        }

        [TestMethod()]
        public void CountAlphaForCase()
        {
            Assert.AreEqual(2, CountAlpha.CountAlphaFunction("aabBcde"));
            Assert.AreEqual(1, CountAlpha.CountAlphaFunction("Indivisibility"));
            Assert.AreEqual(2, CountAlpha.CountAlphaFunction("Indivisibilities"));
        }

    }
}