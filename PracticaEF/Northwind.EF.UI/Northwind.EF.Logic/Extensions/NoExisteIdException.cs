using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.EF.Logic.Extensions
{
    public class NoExisteIdException : Exception
    {
        public NoExisteIdException() : base("El id ingresado no existe en la base de datos.")
        {
        }
    }
}
