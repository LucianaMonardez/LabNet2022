using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionsMethods.Extensions
{
    internal class NoEsParException : Exception
    {
        public NoEsParException() : base("El numero ingresado no es par.")
        {
            
        }
    }
}
