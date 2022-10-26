using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;
            string NombreComplet;
            Console.WriteLine("Ejercicio 10");
            Console.WriteLine("Forma para saber si un cliente puede entrar a un bar");
            //Entrada
            Console.Write("Ingresa el nombre completo: ");
            NombreComplet = Console.ReadLine();
            Console.Write("Ingresa el valor de edad: ");
            Edad = int.Parse(Console.ReadLine());
            //Proceso y salida
            if (Edad < 18)
                Console.WriteLine("Menor de edad, no puede entrar");
            else
                Console.WriteLine("Mayor de edad, puede entrar");
            Console.WriteLine("Nombre completo: " + NombreComplet);
            Console.ReadKey();
        }
    }
}
