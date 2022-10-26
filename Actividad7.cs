using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar variable
            double Pj, DJ, P;
            //entrada
            Console.WriteLine("descuento por juguete");
            Console.WriteLine("precio de los juguetes");
            Pj = double.Parse(Console.ReadLine());
            //proceso 
            if (Pj > 150)
            {
                DJ = Pj * .10;
            }
            else
            {
                DJ = Pj * .05;
            }
            P = Pj - DJ;
            //salida
            Console.WriteLine("descuento del juguete es de: " + DJ);
            Console.WriteLine("el precio es: " + P);
            Console.ReadKey();
        }
    }
}
