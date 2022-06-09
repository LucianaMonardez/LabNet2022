using Northwind.EF.Data;
using Northwind.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.EF.Logic.Extensions;

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
            if (shipperAEliminar != null)
            {
                _context.Shippers.Remove(shipperAEliminar);
                _context.SaveChangesAsync();
            }
            else 
            {
                throw new NoExisteIdException();
            }
        }

        public Shippers GetById(int id)
        {
            var shipper = _context.Shippers.FirstOrDefault(x => x.ShipperID == id);
            if (shipper != null)
            {
                return shipper;
            }
            else 
            {
                throw new NoExisteIdException();
            }
        }

        public void Update(Shippers shipperAModificar)
        {
            try
            {
                _context.Entry(shipperAModificar).State = EntityState.Modified;
                _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
