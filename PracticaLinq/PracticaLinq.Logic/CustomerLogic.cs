using PracticaLinq.Entities;
using PracticaLinq.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq.Logic
{
    public class CustomerLogic : BaseLogic, ILogic<Customer>
    {
        public void Add(Customer U)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<Customer> GetAllCustomersFromWaRegion()
        {
            return (from customer in _context.Customers
                    where customer.Region == "WA" select customer).ToList();
        }

        public Customer GetById(string id)
        {
                var result = (from customer in _context.Customers
                              where customer.CustomerID == id.ToString()
                              select customer).FirstOrDefault();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new NoExisteIdException();
                }
        }
        public List<string> GetAllCustomersName()
        {
            List<string> customerName = new List<string>();
            var namesUpper =  (from customer in _context.Customers
                    select customer.ContactName.ToUpper()).ToList();
            var namesLower = (from customer in _context.Customers
                              select customer.ContactName.ToLower()).ToList();

            customerName.AddRange(namesUpper);
            customerName.AddRange(namesLower);
            if (customerName != null)
            {
                return customerName;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }

            
        }

        public List<Customer> GetAllCustomersFromRegionWaAndOrderDateHigherThan1997()
        {

            var result = (from customer in _context.Customers
                    join order in _context.Orders
                    on customer.CustomerID equals order.CustomerID
                    where customer.Region == "WA"
                    && order.OrderDate > new DateTime(1997,1,1)
                    select customer).ToList();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }

        public List<Customer> GetFirst3CustomersWhereRegionWA()
        {

            var result =  _context.Customers.Where(x => x.Region == "WA").Take(3).ToList();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }
        public List<string> GetCustomersQuantityOrders()
        {
            var customers = _context.Customers.Select(x => new { CustomerName = x.ContactName, OrderCount = _context.Orders.Count(o => o.CustomerID == x.CustomerID) }).ToList();


            var stringList = new List<string>();

            if (customers != null)
            {
                foreach (var customer in customers)
                {
                    stringList.Add($"Customer Name: {customer.CustomerName}, Order Count: {customer.OrderCount}");
                }

                return stringList;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }

        public void Update(Customer U)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
