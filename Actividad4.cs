using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Estatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
             Double EM = 0;

            //Entrada
            Console.WriteLine("Estatura en metros");
            EM = Double.Parse(Console.ReadLine());

            //Proceso
            if (EM >= 0 && EM <= 1.50)
            {
                Console.WriteLine("Eres chaparr@");
            }
            else
            if (EM >= 1.51 && EM <= 1.65)
            {
                Console.WriteLine("Eres median@");
            }
            else
            if (EM >= 1.66)
            {
                Console.WriteLine("Eres Alt@");
            }

            Console.ReadKey();
        }
    }
}
