<Query Kind="Program">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

// https://www.codechef.com/submit/PROBCAT
void Main()
{
	Console.SetIn(new StringReader(@"
3
50
172
201
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		//var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		var n = int.Parse(Console.ReadLine());

		//switch (n)
		//{
		//	case int x when ( x >= 1 &&  x < 100):
		//		Console.WriteLine("Easy");
		//		break;
		//	case int x when (x >= 100 && x < 200):
		//		Console.WriteLine("Medium");
		//		break;
		//	case int x when (x >= 200 && x <= 300):
		//		Console.WriteLine("Hard");
		//		break;
		//}
		if( n >= 1 &&  n < 100)
		{
			Console.WriteLine("Easy");
		}
		else if(n >= 100 && n < 200)
		{
			Console.WriteLine("Medium");
		}
		else if(n >= 200 && n <= 300)
		{
			Console.WriteLine("Hard");
		}

	}
}

