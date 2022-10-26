using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar variable 
            int x, pag;
            pag = 0;
            //entrada 
            Console.WriteLine("cuanto pagar por cierta cantidad de hamburguesas");
            Console.WriteLine("numero de hamburguesas");
            x = int.Parse(Console.ReadLine());
            //proceso y salida
            if (x >= 5)
            {
                pag = 60;

            }
            else
            {
                pag= 80;
            }
            Console.WriteLine("el pago por cada hamburguesa sera de: " + pag);
            Console.ReadKey();
        }
    }
}
