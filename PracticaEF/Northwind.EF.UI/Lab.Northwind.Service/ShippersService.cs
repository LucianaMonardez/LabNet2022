using Northwind.EF.Entities;
using Northwind.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Northwind.Service
{
    public interface IShippersService
    {
        List<Shippers> GetAll();
        void Add();
        void Delete(int id);
        void Update(Shippers shipper);
    }
    public class ShippersService: IShippersService 
    {
        private readonly IABMLogic Command;
        public ShippersService(IABMLogic repositorio)
        {
            this.Command = repositorio;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shippers> GetAll()
        {
            try
            {

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Shippers shipper)
        {
            throw new NotImplementedException();
        }
    }
}

