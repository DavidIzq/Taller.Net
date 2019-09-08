/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 8/09/2019
 * Time: 1:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double num1,num2,num3;
			Console.WriteLine("Ingrese tres numeros ");
			num1=double.Parse(Console.ReadLine());
			num2=double.Parse(Console.ReadLine());
			num3=double.Parse(Console.ReadLine());
			if(num1==num2 && num1==num3){
				Console.WriteLine("Los tres numeros son iguales");
			}else if(num1>num2&&num1>num3){
				Console.WriteLine("El primer numero es el mayor de los dos ");
			}else if(num2>num1&&num2>num3){
				Console.WriteLine("El numero mayor es el segundo");
			}else if(num3>num1&&num3>num2){
				Console.WriteLine("El  numero mayor es el tercero");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}