using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioExtensionsMethods.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionsMethods.Extensions.Tests
{
    [TestClass()]
    public class EjercicioExceptionsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException), "Attempted to divide by zero.")]
        public void DividirPorCeroTestExepcion()
        {
            //arrange
            int numero1 = 3;
            int numero2 = 0;
            //act
            var resultado = numero1 / numero2;

        }

        [TestMethod()]
        public void DivisionConDosParametrosSuccess() 
        {
            //arrange
            int numero1 = 10;
            int numero2 = 2;
            int esperado = 5;

            //act
            var resultado = numero1 / numero2;

            //assert
            Assert.AreEqual(resultado, esperado);
        }
        [TestMethod()]
        public void DivisionConDosParametrosFail()
        {
            //arrange
            int numero1 = 10;
            int numero2 = 3;
            int esperado = 5;

            //act
            var resultado = numero1 / numero2;

            //assert
            Assert.AreNotEqual(resultado, esperado);
        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException), "Attempted to divide by zero.")]
        public void DivisionConDosParametrosExepcionDivideByZeroException()
        {
            //arrange
            int numero1 = 3;
            int numero2 = 0;
            //act
            var resultado = numero1 / numero2;

        }
    }
}