using Northwind.EF.Data;
using Northwind.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.EF.Logic.Extensions;

namespace Northwind.EF.Logic
{
    public class TerritoriesLogic : BaseLogic, IABMLogic<Territories>
    {
        public List<Territories> GetAll()
        {
            return _context.Territories.ToList();
        }
        public void Add(Territories territory)
        {
            _context.Territories.Add(territory);
            _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var territoryAEliminar = _context.Territories.FirstOrDefault(x => Convert.ToInt32(x.TerritoryID) == id);
            if (territoryAEliminar != null)
            {
                _context.Territories.Remove(territoryAEliminar);
                _context.SaveChangesAsync();
            }
            else
            {
                throw new NoExisteIdException();
            }
        }
        public Territories GetById(int id)
        {
            var territory = _context.Territories.FirstOrDefault(x => Convert.ToInt32(x.TerritoryID) == id);
            if (territory != null)
            {
                return territory;
            }
            else
            {
                throw new NoExisteIdException();
            }
        }

        public Territories Update(Territories U)
        {
            throw new NotImplementedException();
        }

        void IABMLogic<Territories>.Update(Territories U)
        {
            throw new NotImplementedException();
        }
    }
}
