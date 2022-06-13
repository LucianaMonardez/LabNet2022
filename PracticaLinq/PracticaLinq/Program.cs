using PracticaLinq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Menu();
                Console.WriteLine("Ingrese una opcion:");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        GetCustomerById();
                        break;
                    case 2:
                        GetProductsWihoutStock();
                        break;
                    case 3:
                        GetProductsWithStockAndPriceHigherThan3();
                        break;
                    case 4:
                        GetAllCustomersWithWaRegion();
                        break;
                    case 5:
                        GetById789();
                        break;
                    case 6:
                        GetAllCustomersName();
                        break;
                    case 7:
                        GetAllCustomersFromRegionWaAndOrderDateHigherThan1997();
                        break;






                }
            } while (opcion !=10);
        }
        static void Menu()
        {
            Console.WriteLine("\n1- Obtener customer por ID");
            Console.WriteLine("2- Agregar shipper");
            Console.WriteLine("3- Eliminar shipper por numero de id");
            Console.WriteLine("4- Actualizar shipper por numero de id");
            Console.WriteLine("5- Obtener todos los terrritories");
            Console.WriteLine("6- Salir\n");
        }
        static void GetCustomerById() 
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                Console.WriteLine("Ingrese el id del customer a obtener ");
                string id = Console.ReadLine();
                var customer = customerLogic.GetById(id);

                Console.WriteLine($"Customer Id: { customer.CustomerID }, Customer name: { customer.ContactName}, Customer phone {customer.Phone}");

                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void GetProductsWihoutStock()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var products = productLogic.GetAllWithoutStock();

                foreach (var product in products)
                {
                    Console.WriteLine($"Product Id: {product.ProductID}");
                }
                

                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void GetProductsWithStockAndPriceHigherThan3()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var products = productLogic.GetAllProductsInStockWithPriceHigherThan3();

                foreach (var product in products)
                {
                    Console.WriteLine($"Product Id: {product.ProductID}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void GetAllCustomersWithWaRegion()
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                var customers = customerLogic.GetAllCustomersFromWaRegion();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer Id: {customer.ContactName}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void GetById789()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var product = productLogic.GetById789();

                if (product != null)
                {
                    Console.Write($"Product id: {product.ProductName}");
                }
                else
                {
                    Console.Write("El producto no existe en la base de datos");
                }
                


                Console.WriteLine("\nApreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void GetAllCustomersName()
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                var customers = customerLogic.GetAllCustomersName();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void GetAllCustomersFromRegionWaAndOrderDateHigherThan1997()
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                var customers = customerLogic.GetAllCustomersFromRegionWaAndOrderDateHigherThan1997();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer Id: {customer.ContactName}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
