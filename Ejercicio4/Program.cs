/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 4/09/2019
 * Time: 3:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			int unidades,pago=0;
			Console.WriteLine("Digite su nombre");
			nombre=Console.ReadLine();
			Console.WriteLine("Digite sus unidades de consumo");
			unidades=int.Parse(Console.ReadLine());
			if(unidades<200){
				pago=120*unidades;
			}else if(unidades>=400){
				pago=unidades*150;
			}else if(unidades<=600){
				pago=unidades*180;         	
			}else if(unidades>600){
			    pago=unidades*200;     	
			}
		    Console.WriteLine("Señor(a)"+nombre+" su factura tiene un valor de "+pago);
			
			
			
			
			
			
			

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}