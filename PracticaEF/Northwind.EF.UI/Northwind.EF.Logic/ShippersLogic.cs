using Northwind.EF.Data;
using Northwind.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {

        public List<Shippers> GetAll()
        { 
            return _context.Shippers.ToList();
        }

        public void Add(Shippers newShipper)
        {
            _context.Shippers.Add(newShipper);
            _context.SaveChangesAsync();    
        }

        public void Delete(int id)
        {
            var shipperAEliminar = _context.Shippers.FirstOrDefault(x => x.ShipperID == id);
            _context.Shippers.Remove(shipperAEliminar);
            _context.SaveChangesAsync();
        }

        public void Update(int id)
        {
            Shippers shipper = new Shippers();
            var shipperAActualizar = _context.Shippers.FirstOrDefault(x => x.ShipperID == id);
            shipperAActualizar.CompanyName = shipper.CompanyName;
            shipperAActualizar.Phone = shipper.Phone;
            _context.SaveChangesAsync();
        }

    }
}
