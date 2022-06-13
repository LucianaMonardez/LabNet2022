using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq.Logic.Exceptions
{
    public class NoExistenDatosParaMostrarException : Exception
    {
        public NoExistenDatosParaMostrarException() : base("No existen entradas para mostrar en la base de datos.")
        {
        }
    }
}
