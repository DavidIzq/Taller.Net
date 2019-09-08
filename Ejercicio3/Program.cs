/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 4/09/2019
 * Time: 2:32 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int mes;
			Console.WriteLine("Digite el mes (1-12)");
			mes=int.Parse(Console.ReadLine());
			if(mes==1||mes==3||mes==5||mes==7||mes==8||mes==10||mes==12){
				Console.WriteLine("Este mes tiene 31 dias");
			}else if(mes==2){
				Console.WriteLine("Este mes tiene 28 dias(29 en año bisiesto)");
			}else{
				Console.WriteLine("Este mes tiene 30 dias");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}