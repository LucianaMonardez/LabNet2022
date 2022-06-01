using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioExtensionsMethods.Extensions;
using EjercicioExtensionsMethods.Logic;

namespace EjercicioExtensionsMethods
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
                            Ejercicio1();
                            break;
                        case 2:
                            Ejercicio2();
                            break;
                        case 3:
                            Ejercicio3();
                            break;
                        case 4:
                            Ejercicio4();
                            break;
                    }

                } while (opcion != 5);
            }
            catch (Exception)
            {
                Console.WriteLine("\nSolo se permiten carcteres numericos. El programa se cerrara, por favor apreta una tecla.");
                Console.ReadKey();
            }
        }

        static void Menu()
        {
            Console.WriteLine("\n1- Ejercicio 1: dividiendo un numero por 0");
            Console.WriteLine("2- Ejercicio 2: dividiento 2 numeros y que tire uan excepcion cuando se intenta dividir por 0");
            Console.WriteLine("3- Ejercicio 3: clase de tipo logic que tire una excepcion");
            Console.WriteLine("4- Ejercicio 4: clase de tipo logic que tire una excepcion personalizada");
            Console.WriteLine("5- Salir\n");
        }
        static void Ejercicio1() 
        {
            Console.WriteLine("Ingresa un numero:");
            var numero = int.Parse(Console.ReadLine());
            EjercicioExceptions.DividirPorCero(numero);
        }
        static void Ejercicio2()
        {
            Console.WriteLine("Ingresa el primer numero:");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero:");
            var numero2 = int.Parse(Console.ReadLine());
            EjercicioExceptions.DivisionConDosParametros(numero1, numero2);
        }
        static void Ejercicio3() 
        {
            try
            {
                ClaseLogic logic = new ClaseLogic();
                Console.WriteLine("Ejercicio 3: clase de tipo logic que tire una excepcion\n");
                Console.WriteLine("Ingresa un numero natural menor a 255:");
                var numero = byte.Parse(Console.ReadLine());
                if (numero > 255)
                {
                    logic.ValidarByte();
                }
                else
                {
                    Console.WriteLine($"El numero {numero} es de tipo byte");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine(e.GetType().Name);
            }
        }
        static void Ejercicio4() 
        {
            try
            {
                ClaseLogic logic = new ClaseLogic();
                Console.WriteLine("Ejercicio 4: clase de tipo logic que tire una excepcion\n");
                Console.WriteLine("Ingresa un numero que sea par:");

                var numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El numero {numero} es par");
                }
                else
                {
                    logic.ValidarNumeroPar();
                }

            }
            catch (NoEsParException e)
            {
                MessageBox.Show(e.Message.ToString(), "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
