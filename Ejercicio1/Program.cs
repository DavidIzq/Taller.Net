/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 4/09/2019
 * Time: 1:32 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opcion;
			double num1,num2,sum,res,por,div;
			Console.WriteLine(" Digite un número:  ");
			num1=double.Parse(Console.ReadLine());
		    Console.WriteLine(" Digite segundo numero:");
		    num2=double.Parse(Console.ReadLine());
		    Console.WriteLine("Las opciones son: ");
		    Console.WriteLine("1--	Adicion           ");
		    Console.WriteLine("2--	Sustraccion       ");
		    Console.WriteLine("3--	Multiplicación    ");
		    Console.WriteLine("4--	Division          ");
		    Console.WriteLine("   Digite su elección  ");
		    opcion=int.Parse(Console.ReadLine());
		    
		    switch(opcion){
		      case 1:
		       sum=num1+num2;
		         Console.WriteLine("La suma de los dos numeros es de "+sum);
		       break;
		       case 2:
		       res=num1-num2;
		         Console.WriteLine("La resta de los dos numeros es de "+res);
		       break;
		      case 3:
		       por=num1*num2;
		         Console.WriteLine("La multiplicacion de los dos numeros es de "+por);
		       break;
		      case 4:
		       div=num1/num2;
		         Console.WriteLine("La division entre los dos numeros es de "+div);
		       break;
		      default:
		         Console.WriteLine("Opcion incorrecta");
		       break;
		     }
			
			
			
			
			
			
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}