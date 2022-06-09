using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.EF.Entities;
using Northwind.EF.Logic;


namespace Northwind.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            try
            {
                do
                {
                    Menu();
                    Console.WriteLine("Ingrese una opcion:");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            ObtenerShippers();
                            break;
                        case 2:
                            AgregarShipper();

                            ObtenerShippers();
                            break;
                        case 3:
                            EliminarShipper();
                            ObtenerShippers();
                            break;
                        case 4:
                            ActualizarShipper();
                            ObtenerShippers();
                            break;
                        case 5:
                            ObtenerTerritories();
                            break;
                    }
                } while (opcion != 6);
            }
            catch (Exception)
            {
                Console.WriteLine("\nSolo se permiten carcteres numericos. El programa se cerrara, por favor apreta una tecla.");
                Console.ReadKey();
            }
            
            Console.ReadLine();
        }
        static void Menu()
        {
            Console.WriteLine("\n1- Obtener todos los shippers");
            Console.WriteLine("2- Agregar shipper");
            Console.WriteLine("3- Eliminar shipper por numero de id");
            Console.WriteLine("4- Actualizar shipper por numero de id");
            Console.WriteLine("5- Obtener todos los terrritories");
            Console.WriteLine("6- Salir\n");
        }
        static void ObtenerShippers() 
        {
            try
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                foreach (Shippers shipper in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID: {shipper.ShipperID}, Nombre de compania: {shipper.CompanyName}, Telefono: {shipper.Phone}");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        static void AgregarShipper() 
        {
            try
            {
                Console.WriteLine("\nIngrese el nombre de la compania:");
                var companyName = Console.ReadLine();
                Console.WriteLine("\nIngrese el numero de telefono de la compania:");
                var phone = Console.ReadLine(); ;

                ShippersLogic shippersLogic = new ShippersLogic();

                shippersLogic.Add(new Shippers
                {
                    CompanyName = companyName,
                    Phone = phone,
                });
                Console.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
        }

        static void EliminarShipper()
        {
            try
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                Console.WriteLine("Ingrese el id del shipper a eliminar: ");
                int id = int.Parse(Console.ReadLine());
                if (id != 0)
                {
                    shippersLogic.Delete(id);
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void ActualizarShipper()
        {
            try
            {
                Console.WriteLine("\nIngrese el nombre de la compania:");
                var companyName = Console.ReadLine();
                if (companyName == null)
                {
                    Console.WriteLine("\nIngrese el nombre de la compania:");
                    companyName = Console.ReadLine();
                }
                Console.WriteLine("\nIngrese el numero de telefono de la compania:");
                var phone = Console.ReadLine();
                if (phone == null)
                {
                    Console.WriteLine("\nIngrese el nombre de la compania:");
                    phone = Console.ReadLine();
                }

                ShippersLogic shippersLogic = new ShippersLogic();

                Console.WriteLine("Ingrese el id del shipper a actualizar: ");
                var id = Convert.ToInt32(Console.ReadLine());
                /*if (id != 0)
                {
                    shippersLogic.Update(id)
                    {
                        CompanyName = companyName,
                        Phone = phone,
                    };
                    Console.ReadLine();
                }*/
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        static void ObtenerTerritories()
        {
            try
            {
                TerritoriesLogic territoriesLogic = new TerritoriesLogic();
                foreach (Territories territory in territoriesLogic.GetAll())
                {
                    Console.WriteLine($"Territorio ID: {territory.TerritoryID}, Region ID: {territory.RegionID}, Descripcion: {territory.TerritoryDescription}");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
