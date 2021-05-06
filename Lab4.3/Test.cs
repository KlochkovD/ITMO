namespace Utils
{
	using System;

	public class Test
	{
		public static void Main()
		{
            int f; 
            bool ok;
            int x;



            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());

           
            ok = Utils.Factorial(x, out f);
            

            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");

          
		}
	}
}
