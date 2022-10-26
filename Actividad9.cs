using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9_Diferencia_de_dos_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            Double A, B, D;

            //Entrada
            Console.WriteLine("Diferencia de dos numeros");
            Console.WriteLine("Primer valor:");
            A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            B = Double.Parse(Console.ReadLine());

            //Proceso
            if (A > B)
            {
                D = A - B;
                Console.WriteLine("La diferencia es: " + D);
            }
            else
            if (B > A)
            {
                D = B - A;
                Console.WriteLine("La diferencia es: " + D);
            }            
           
            Console.ReadKey();

        }
    }
}
