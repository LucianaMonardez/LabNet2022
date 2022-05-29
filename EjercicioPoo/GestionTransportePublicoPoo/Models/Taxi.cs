using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTransportePublicoPoo.Models
{
    internal class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {
        }
    }
}
