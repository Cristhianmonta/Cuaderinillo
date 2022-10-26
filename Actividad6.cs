using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dt, nb, pb, subt, t;
            //Entrada
            Console.WriteLine("numero de barras que se venden por dia");
            nb=double.Parse(Console.ReadLine());
            Console.WriteLine("Precio de las barras");
            pb = double.Parse(Console.ReadLine());
            Console.WriteLine("numero de dias trabajados");
            dt = double.Parse(Console.ReadLine());
            //Proceso y salida
            subt = nb * pb;
            t = subt * dt;
            Console.WriteLine("La venta total fue de"+ t);
            Console.ReadKey();
        }
    }
}
