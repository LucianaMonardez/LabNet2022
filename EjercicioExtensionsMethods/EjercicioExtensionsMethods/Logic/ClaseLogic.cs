using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioExtensionsMethods.Extensions;
using System.Windows.Forms;

namespace EjercicioExtensionsMethods.Logic
{
    public class ClaseLogic
    {
        public static void ValidarByte()
        {
            try
            {
                Console.WriteLine("Ejercicio 3: clase de tipo logic que tire una excepcion\n");
                Console.WriteLine("Ingresa un numero natural menor a 255:");
                var numero = byte.Parse(Console.ReadLine());
                Console.WriteLine($"El numero {numero} es de tipo byte");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine(e.GetType());
            }
        }
        public static void ValidarNumeroPar()
        {
            try
            {
                Console.WriteLine("Ejercicio 4: clase de tipo logic que tire una excepcion\n");
                Console.WriteLine("Ingresa un numero que sea par:");

                var numero = int.Parse(Console.ReadLine());
                
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El numero {numero} es par");
                }
                else
                {
                    throw new NoEsParException();
                }

            }
            catch (NoEsParException e)
            {
                MessageBox.Show(e.Message.ToString(), "Algo salio mal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
