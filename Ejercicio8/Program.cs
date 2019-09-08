/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 8/09/2019
 * Time: 2:31 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{

			double precio,descuento=0;
            Console.WriteLine("Digite valor del articulo que llevó");
			precio=double.Parse(Console.ReadLine());
			if(precio>=200){
				descuento=precio-(precio*0.15);
			}else if(precio<200){
				descuento=precio-(precio*0.12);
			}else if(precio<100){
				descuento=precio-(precio*0.12);
			}
			Console.WriteLine("Usted tenia que pagar "+precio);
			Console.WriteLine("Su total a pagar con descuento es de "+descuento);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}