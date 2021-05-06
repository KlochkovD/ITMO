namespace Utils
{
	using System;

	public class Test
	{
		public static void Main()
		{
            int f; // Factorial result
            bool ok; // Factorial success or failure
            int x;



            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());

            // Test the factorial function
            ok = Utils.Factorial(x, out f);
            // Output factorial results

            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");

          
		}
	}
}
