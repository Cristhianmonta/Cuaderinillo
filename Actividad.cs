using System;
using System.Linq;

namespace Activ1
{
	public static class Program
	{
		public static void Main()
		{
			 //Declarar variables
doble CP , PF , DESC ;
consola _ WriteLine ( " Ejercicio 1 " );
consola _ WriteLine ( " Programa para calcular el descuento por cierta cantidad a " );
// Entrada
consola _ WriteLine ( " Ingrese la cantidad a pagar " );
CP = doble . Analizar ( Consola . ReadLine ());
// Proceso y salida
si ( CP >= 1800 )
{
DESC = PC * 0 . 30 ;
}
más
{
DESC = PC * 0 . 10 ;
}
PF = CP - DESC ;
consola _ WriteLine ( " El descuento es de: " + DESC );
consola _ WriteLine ( " La cantidad final a pagar es de: " + PF );
consola _ Clave de lectura ();
}
}
}
