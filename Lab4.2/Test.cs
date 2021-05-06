namespace Utils
{
	using System;

	public class Test
	{
		public static void Main()
		{
			int x;
			int y;

			Console.WriteLine("Enter first number:");
			x = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter second number:");
			y = int.Parse(Console.ReadLine());

			Console.WriteLine("Before swap: " + x + "," + y);
			Utils.Swap(ref x, ref y);
			Console.WriteLine("After swap: " + x + "," + y);
		}
	}
}

