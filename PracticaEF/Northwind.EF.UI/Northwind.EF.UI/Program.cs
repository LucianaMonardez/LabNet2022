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
            while (true)
            {
                Menu();
                Console.WriteLine("Ingrese una opcion:");
                string opcion = Console.ReadLine();
                if (int.TryParse(opcion, out int choice))
                {
                    if (choice < 5)
                    {
                        switch (choice)
                        {
                            case 1:
                                ObtenerShippers();
                                break;
                            case 2:
                                AgregarShipper();
                                break;
                            case 3:
                                EliminarShipper();
                                break;
                            case 4:
                                ActualizarShipper();
                                break;
                            case 5:
                                ObtenerTerritories();
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
            Console.WriteLine("\n1- Obtener todos los shippers");
            Console.WriteLine("2- Agregar shipper");
            Console.WriteLine("3- Eliminar shipper por numero de id");
            Console.WriteLine("4- Actualizar shipper por numero de id");
            Console.WriteLine("5- Obtener todos los terrritories");
            Console.WriteLine("6- Salir\n");
        }
        protected static void ObtenerShippers() 
        {
            try
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                foreach (Shippers shipper in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID: {shipper.ShipperID}, Nombre de compania: {shipper.CompanyName}, Telefono: {shipper.Phone}");
                }
                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected static void AgregarShipper() 
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
                Console.WriteLine("Apreta cualquier tecla para continuar");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected static void EliminarShipper()
        {
            try
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                Console.WriteLine("Ingrese el id del shipper a eliminar: ");
                int id = int.Parse(Console.ReadLine());
                if (id != 0)
                {
                    shippersLogic.Delete(id);
                    ObtenerShippers();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        protected static void ActualizarShipper()
        {
            try
            {
                ShippersLogic shippersLogic = new ShippersLogic();

                Console.WriteLine("Ingrese el id del shipper a actualizar: ");
                var id = Convert.ToInt32(Console.ReadLine());
                var shipper = shippersLogic.GetById(id);
                if (shipper != null)
                {
                    Console.WriteLine("\nIngrese el nombre de la compania:");
                    var companyName = Console.ReadLine();
                    while (string.IsNullOrEmpty(companyName))
                    {
                        Console.WriteLine("\nEl nombre de la compañia es obligatorio. Ingrese el nombre de la compania:");
                        companyName = Console.ReadLine();
                    }
                    Console.WriteLine("\nIngrese el numero de telefono de la compania:");
                    var phone = Console.ReadLine();
                    if (!string.IsNullOrEmpty(phone))
                    {
                        shipper.Phone = phone;
                    }

                    shipper.CompanyName = companyName;
                    

                    shippersLogic.Update(shipper);

                    ObtenerShippers();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        protected static void ObtenerTerritories()
        {
            try
            {
                TerritoriesLogic territoriesLogic = new TerritoriesLogic();
                foreach (Territories territory in territoriesLogic.GetAll())
                {
                    Console.WriteLine($"Territorio ID: {territory.TerritoryID}, Region ID: {territory.RegionID}, Descripcion: {territory.TerritoryDescription}");
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
