using System.Diagnostics;

namespace Business
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int oldtype = 3;
			Console.WriteLine("We are about to have a business ");

			Console.WriteLine("This is our main code");

			Console.WriteLine("this is our not so new feature");

			Console.WriteLine("This is our footer - (c)2019");

			Console.WriteLine("this might be a cool thing one day but not today");

			Console.WriteLine("this might be some extra");
			MyMethod(oldtype);

		}
		public static void MyMethod(int oldtype)
		{
			Console.WriteLine("how dont you do");

			int newtype = 2 - 17;

			newtype += oldtype; 
		}
	}
}