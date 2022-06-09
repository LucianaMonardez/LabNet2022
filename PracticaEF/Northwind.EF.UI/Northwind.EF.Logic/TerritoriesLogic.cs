using Northwind.EF.Data;
using Northwind.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var territoryAEliminar = _context.Territories.FirstOrDefault(x => Convert.ToInt32(x.TerritoryID) == id );
            _context.Territories.Remove(territoryAEliminar);
            _context.SaveChangesAsync();
        }

        public void Update(int id)
        {
            Territories terrytory = new Territories();
            var territoryAActualizar = _context.Territories.FirstOrDefault(x => Convert.ToInt32(x.TerritoryID) == id);
            territoryAActualizar.TerritoryDescription = terrytory.TerritoryDescription;
            territoryAActualizar.RegionID = terrytory.RegionID;
            _context.SaveChangesAsync();
        }
    }
}
