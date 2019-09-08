/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 5/09/2019
 * Time: 4:31 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			char c;
			Console.WriteLine("Digite cualquier caracter");
			c=char.Parse(Console.ReadLine().ToLower());
		
			if('c'=='a'||'c'=='e'||'c'=='i'||'c'=='o'||'c'=='u'){
			   	Console.WriteLine("Este caracter es una vocal");
			}else if ('c'=='b'||'c'=='c'||'c'=='d'||'c'=='f'||'c'=='g'||'c'=='h'||'c'=='j'||'c'=='k'||'c'=='l'||'c'=='m'||'c'=='n'||'c'=='p'||'c'=='q'||'c'=='r'||'c'=='s'||'c'=='t'||'c'=='v'||'c'=='w'||'c'=='x'||'c'=='y'||'c'=='z'){
			   	Console.WriteLine("Este caracter es una consonante");
			}else{
					Console.WriteLine("Este caracter no es ni vocal ni consonante");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}