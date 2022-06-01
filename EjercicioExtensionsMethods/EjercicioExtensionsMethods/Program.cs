using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioExtensionsMethods.Extensions;
using EjercicioExtensionsMethods.Logic;

namespace EjercicioExtensionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ejercicio 1: dividiendo un numero por 0\n");
            Console.WriteLine("Ingresa un numero:");
            var numero = int.Parse(Console.ReadLine());
            EjercicioExceptions.DividirPorCero(numero);
            Console.WriteLine("\nAprieta una tecla para continuar\n");
            Console.ReadKey();

            Console.WriteLine("Ejercicio 2: dividiento 2 numeros y que tire uan excepcion cuando uno de los numeros es 0\n");
            Console.WriteLine("Ingresa el primer numero:");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero:");
            var numero2 = int.Parse(Console.ReadLine());
            EjercicioExceptions.DivisionConDosParametros(numero1, numero2);
            Console.WriteLine("\nAprieta una tecla para continuar\n");
            Console.ReadKey();
            
            ClaseLogic.ValidarByte();
            Console.WriteLine("\nAprieta una tecla para continuar\n");
            Console.ReadKey();
            

            ClaseLogic.ValidarNumeroPar();
            Console.WriteLine("\nAprieta una tecla para finalizar\n");
            Console.ReadKey();
        }
    }
}
