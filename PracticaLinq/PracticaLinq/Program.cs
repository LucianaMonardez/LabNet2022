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
            while (true)
            {
                Menu();
                Console.WriteLine("Ingrese una opcion:");
                string opcion = Console.ReadLine();
                if (int.TryParse(opcion, out int choice))
                {
                    if (choice < 14)
                    {
                        switch (choice)
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
                            case 8:
                                GetFirst3Customers();
                                break;
                            case 9:
                                GetAllProductsOrderedByName();
                                break;
                            case 10:
                                GetAllProductsOrderedByUnitInStockDesc();
                                break;
                            case 11:
                                GetFirstProduct();
                                break;
                            case 12:
                                GetCustomersQuantityOrders();
                                break;
                            case 13:
                                GetProductCategorys();
                                break;
                        }
                    }

                    else
                    {
                        Environment.Exit(0);
                        Console.Write("Apreta cualquier tecla para salir");
                    }
                }
                else
                {
                    Console.Write("\nIngrese un valor valido");
                }
            }
        }
        protected static void Menu()
        {
            Console.WriteLine("\n1- Obtener customer por ID");
            Console.WriteLine("2- Obtener productos sin stock");
            Console.WriteLine("3- Obtener ttodos los productos en stock y que cuesten mas de $3");
            Console.WriteLine("4- Obtener clientes en la region WA");
            Console.WriteLine("5- Obtener por ID 789");
            Console.WriteLine("6- Obtener los nombres d elos customers y mostrarlos en mayuscula y en minuscula");
            Console.WriteLine("7- Obtener Join entre customers y orders donde los customers sean de region WA y la fecha de orden sea mayor a 1/1/1997");
            Console.WriteLine("8- Obtener los primeros 3 customers de la region WA");
            Console.WriteLine("9- Obtener productos ordenados por nombre");
            Console.WriteLine("10- Obtener productos ordenados por unit in stock de mayor a menor");
            Console.WriteLine("11- Obtener el primer elemento de la lista de productos");
            Console.WriteLine("12- Obtener los customers y la cantidad de ordenes asociadas");
            Console.WriteLine("13- Obtener las distintas categorias asociadas a los productos");
            Console.WriteLine("14- Salir\n");
        }
        protected static void GetCustomerById() 
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                Console.WriteLine("Ingrese el id del customer a obtener ");
                string id = Console.ReadLine();
                var customer = customerLogic.GetById(id);

                Console.WriteLine($"Customer Id: { customer.CustomerID }, Customer name: { customer.ContactName}, Customer phone {customer.Phone}, Customer region: {customer.Region}");

                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        protected static void GetProductsWihoutStock()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var products = productLogic.GetAllWithoutStock();

                foreach (var product in products)
                {
                    Console.WriteLine($"Product Id: {product.ProductID}, Product name: {product.ProductName}, Units in stock: {product.UnitsInStock}, Unit price: {product.UnitPrice}");
                }
                

                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        protected static void GetProductsWithStockAndPriceHigherThan3()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var products = productLogic.GetAllProductsInStockWithPriceHigherThan3();

                foreach (var product in products)
                {
                    Console.WriteLine($"Product Id: {product.ProductID}, Product name: {product.ProductName}, Units in stock: {product.UnitsInStock}, Unit price: {product.UnitPrice}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        protected static void GetAllCustomersWithWaRegion()
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                var customers = customerLogic.GetAllCustomersFromWaRegion();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer Id: {customer.CustomerID}, Customer name: {customer.ContactName}, Customer phone {customer.Phone}, Region: {customer.Region}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        protected static void GetById789()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var product = productLogic.GetById789();

                if (product != null)
                {
                    Console.Write($"Product id: {product.ProductID}, Product name: {product.ProductName}, Units in stock: {product.UnitsInStock}, Unit price: {product.UnitPrice}");
                }
                else
                {
                    Console.Write("El producto no existe en la base de datos");
                }
                


                Console.WriteLine("\nApreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        protected static void GetAllCustomersName()
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
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        protected static void GetAllCustomersFromRegionWaAndOrderDateHigherThan1997()
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                var customers = customerLogic.GetAllCustomersFromRegionWaAndOrderDateHigherThan1997();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer Id: {customer.CustomerID}, Customer name: {customer.ContactName}, Customer phone {customer.Phone}, Orders: {customer.Orders}, Region: {customer.Region}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); 
            }
        }
        protected static void GetFirst3Customers()
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                var customers = customerLogic.GetFirst3CustomersWhereRegionWA();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer ID: {customer.CustomerID}, Customer name: {customer.ContactName}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        protected static void GetAllProductsOrderedByName()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var products = productLogic.GetAllProductsOrderedByName();

                foreach (var product in products)
                {
                    Console.WriteLine($"Product Id: {product.ProductID}, Product name: {product.ProductName}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        protected static void GetAllProductsOrderedByUnitInStockDesc()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var products = productLogic.GetAllProductsOrderedByUnitInStockDesc();

                foreach (var product in products)
                {
                    Console.WriteLine($"Product Id: {product.ProductID}, Product name: {product.ProductName}, Unit in stock: {product.UnitsInStock}");
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        protected static void GetFirstProduct()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var product = productLogic.GetFirstProduct();

                    Console.WriteLine($"Product Id: {product.ProductID}, Product name: {product.ProductName}, Product in stock: {product.UnitsInStock}");


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        protected static void GetCustomersQuantityOrders()
        {
            try
            {
                CustomerLogic customerLogic = new CustomerLogic();
                var customers = customerLogic.GetCustomersQuantityOrders();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }


                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        protected static void GetProductCategorys()
        {
            try
            {
                ProductLogic productLogic = new ProductLogic();
                var products = productLogic.GetProductCategorys();

                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }

                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
