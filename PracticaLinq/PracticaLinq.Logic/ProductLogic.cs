using PracticaLinq.Entities;
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
            return (from product in _context.Products 
                    where product.UnitsInStock == 0
                    select product).ToList();
        }
        public List<Product> GetAllProductsInStockWithPriceHigherThan3()
        {
            return (from product in _context.Products
                    where product.UnitsInStock != 0
                    && product.UnitPrice > 3 
                    select product).ToList();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Product GetById789()
        {
            return (from product in _context.Products
                    where product.ProductID == 789
                    select product).FirstOrDefault();
        }

        public List<Product> GetAllProductsOrderedByName()
        {
            return _context.Products.OrderBy(x => x.ProductName).ToList();
        }
        public List<Product> GetAllProductsOrderedByUnitInStockDesc()
        {
            return _context.Products.OrderByDescending(x => x.UnitsInStock).ToList();
        }
        public List<string> GetProductCategorys()
        {
            return _context.Products.Join(_context.Categories, product => product.CategoryID, category =>  category.CategoryID, (product, category) => category.CategoryName).ToList();
        }
        public Product GetFirstProduct()
        {
            return _context.Products.FirstOrDefault();
        }

        public void Update(Product U)
        {
            throw new NotImplementedException();
        }
    }
}
