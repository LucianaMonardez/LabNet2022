using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTransportePublicoPoo.Models
{
    internal abstract class TransportePublico
    {
        public TransportePublico(int pasajeros)
        {
            this.SetPasajeros(pasajeros);
        }

        private int pasajeros;

        public int GetPasajeros()
        {
            return pasajeros;
        }

        public void SetPasajeros(int value)
        {
            pasajeros = value;
        }

        public void Avanzar() 
        {
            throw new NotImplementedException();
        }
        public void Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
