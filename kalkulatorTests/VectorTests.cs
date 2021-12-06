using Microsoft.VisualStudio.TestTools.UnitTesting;
using kalkulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator.Tests
{
    [TestClass()]
    public class VectorTests
    {

        [TestMethod()]
        public void VerboseTest()
        {
            var vector = new Vector(10, 5, 3);
            Assert.AreEqual("10, 5", vector.Verbose());
        }

        [TestMethod()]
        public void AddNumberTest()
        {
            Vector Vect1 = new Vector(5, 26, 3);
            Vector Vect2 = new Vector(1, 18, 3);
            Vector vector = Vect1 + Vect2;
            Assert.AreEqual("6, 44, 6", vector.Verbose());
        }

        [TestMethod()]
        public void SubNumberTest()
        {
            Vector Vect1 = new Vector(5, 26, 3);
            Vector Vect2 = new Vector(1, 18, 3);
            Vector answer = Vect1 - Vect2;
            Assert.AreEqual("4, 8, 0", answer.Verbose());
        }
    }
}