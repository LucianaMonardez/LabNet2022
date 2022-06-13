using PracticaLinq.Entities;
using PracticaLinq.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq.Logic
{
    public class ProductLogic : BaseLogic, ILogic<Product>
    {
        public void Add(Product U)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllWithoutStock()
        {
            var result = (from product in _context.Products 
                    where product.UnitsInStock == 0
                    select product).ToList();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }
        public List<Product> GetAllProductsInStockWithPriceHigherThan3()
        {
            var result = (from product in _context.Products
                    where product.UnitsInStock != 0
                    && product.UnitPrice > 3 
                    select product).ToList();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Product GetById789()
        {
            var result = (from product in _context.Products
                    where product.ProductID == 789
                    select product).FirstOrDefault();
            if (result != null)
            {
                return result;
            }
            else 
            {
                throw new NoExisteIdException();
            }
        }

        public List<Product> GetAllProductsOrderedByName()
        {
            var result = _context.Products.OrderBy(x => x.ProductName).ToList();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }
        public List<Product> GetAllProductsOrderedByUnitInStockDesc()
        {
            var result = _context.Products.OrderByDescending(x => x.UnitsInStock).ToList();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }
        public List<string> GetProductCategorys()
        {
            var result = _context.Products.Join(_context.Categories, product => product.CategoryID, category =>  category.CategoryID, (product, category) => category.CategoryName).ToList();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }
        public Product GetFirstProduct()
        {
            var result = _context.Products.FirstOrDefault();
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new NoExistenDatosParaMostrarException();
            }
        }

        public void Update(Product U)
        {
            throw new NotImplementedException();
        }
    }
}
