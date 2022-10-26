using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 0, d = 0, p = 0, t = 0;
            char op = ' ';
            Console.WriteLine("elija el tipo de pan que va a llevar");
            Console.WriteLine(" C = Concha");
            Console.WriteLine(" B = Banderilla");
            Console.WriteLine(" M = Moño");
            //Entrada
            op = char.Parse(Console.ReadLine());
            //Proceso y salida
            if (op == 'C' || op == 'c' || op == 'B' || op == 'b' || op == 'M' || op == 'm')
            {
                Console.WriteLine("¿Cuantos panes llevara?:");
                c = double.Parse(Console.ReadLine());
                switch (op)
                {
                    case 'c':
                    case 'C':
                        p = 3.5;
                        d = (p*5)/100;
                        t = c * (p - d);
                        break;
                    case 'b':
                    case 'B':
                        p = 6;
                        d = (p * 3)/100;
                        t = c * (p - d);
                        break;
                    case 'm':
                    case 'M':
                        p = 10;
                        d = (p * 10) / 100;
                        t = c * (p - d);
                        break;
                }
                Console.WriteLine("El total a pagar de panes es de:" + t);
                Console.WriteLine("El descuento fue de:" + d);
    }
            else
            {
                Console.WriteLine("Elija un tipo de pan disponible");
            }
            Console.ReadKey();
        }
    }
}
