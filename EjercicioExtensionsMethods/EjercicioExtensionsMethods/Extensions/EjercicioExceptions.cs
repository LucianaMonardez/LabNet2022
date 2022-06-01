using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtensionsMethods.Extensions
{
    public static class EjercicioExceptions
    {
        public static void DividirPorCero(this int numero1)
        {
            try
            {
                int numero2 = 0;
                var resultado = numero1 / numero2;
                if (numero1 != 0 || numero2 != 0)
                {
                    Console.WriteLine($"El resultado de la division entre {numero1} y {numero2} es: {resultado}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error al intentar dividir por 0.");
                Console.WriteLine(e.Message.ToString());
            }
            finally 
            {
                Console.WriteLine("La operacion finalizo.");
            }
        }

        public static void DivisionConDosParametros(this int numero1, int numero2)
        {
            try
            {
                var resultado = numero1 / numero2;
                if (numero1 != 0 || numero2 != 0)
                {
                    Console.WriteLine($"El resultado de la division entre {numero1} y {numero2} es: {resultado}");
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
            }

            catch (Exception e)
            {
                Console.WriteLine("Seguro ingresaste una letra o no ingresaste nada!");
                throw new Exception(e.Message.ToString());
            }
            finally
            {
                Console.WriteLine("La operacion finalizo.");
            }
        }

    }

}
