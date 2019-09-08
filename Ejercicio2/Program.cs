/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 4/09/2019
 * Time: 1:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opcion;
			double r,area,b,h;
			Console.WriteLine("Programa para calcular el area de distintas areas geometricas ");
			Console.WriteLine("..............................................................");
			Console.WriteLine("1-- Area del circulo   ");
			Console.WriteLine("2-- Area del rectangulo");
			Console.WriteLine("3-- Area del triangulo ");
			opcion=int.Parse(Console.ReadLine());
			switch(opcion){
				case 1:
					Console.WriteLine(" Digite el radio ");
					r=double.Parse(Console.ReadLine());
					area=Math.PI*Math.Pow(r,2);
					Console.WriteLine("El area del circulo es de "+area);
			     break;
			    case 2:
			      Console.WriteLine(" Digite la  base ");
			    b=double.Parse(Console.ReadLine());
			        Console.WriteLine("Digite la altura");
			        h=int.Parse(Console.ReadLine());
			        area=b*h;
					Console.WriteLine("El area del rectangulo es de "+area);
			     break;
			    case 3:
			      Console.WriteLine(" Digite la  base ");
			    b=double.Parse(Console.ReadLine());
			        Console.WriteLine("Digite la altura");
			        h=int.Parse(Console.ReadLine());
			        area=(b*h)/2;
					Console.WriteLine("El area del triangulo es de "+area);
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