using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioExtensionsMethods.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionsMethods.Logic.Tests
{
    [TestClass()]
    public class ClaseLogicTests
    {
        [TestMethod()]
        public void ValidarByteTestFail()
        {
            var numero = 300;
            var esperado = 30;

            Assert.AreNotEqual(numero, esperado);
        }
        [TestMethod()]
        public void ValidarByteTestSuccess()
        {
            var numero = 30;
            var esperado = 30;

            Assert.AreEqual(numero, esperado);
        }

        [TestMethod()]
        public void ValidarNumeroParTestSuccess()
        {
            var numero = 2;
            var esperado = 2;

            Assert.AreEqual(numero, esperado);
        }
        [TestMethod()]
        public void ValidarNumeroParTestFail()
        {
            var numero = 2;
            var esperado = 3;

            Assert.AreNotEqual(numero, esperado);
        }

    }
}