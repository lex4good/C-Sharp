using System;

namespace First_app
{
	class Program
				
	{
		public static int incrementation (ref int num)
			{		
			
			return num++;
		
		}			
		
		public static void Main(string[] args)
		{
			int a = Convert.ToInt32 (Console.ReadLine()) ;
			//++a;
			incrementation (ref a);
			Console.WriteLine (a);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			}
		
		
	}
}