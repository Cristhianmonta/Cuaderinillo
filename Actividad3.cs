using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Aguacates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int CK, PK = 0, CF = 0;

            //Entrada
            Console.WriteLine("Aguacates");
            Console.WriteLine("Cantidad de kilos: ");
            CK = int.Parse(Console.ReadLine());

            //Proceso
            if (CK >= 1 && CK <= 5)
            {
                PK = 50;
                CF = CK * PK;
            }
            else
            if(CK >= 5)            {
                PK = 45;
                CF = CK * PK;
            }
            Console.WriteLine("Costo Final es de:" + CF );
            Console.WriteLine("Valor de aguacate: " + PK);
            Console.ReadKey();
        }
    }
}
