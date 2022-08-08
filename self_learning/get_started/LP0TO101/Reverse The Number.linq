<Query Kind="Program" />

// https://www.codechef.com/LP0TO101/problems/FLOW007
void Main()
{
	Console.SetIn(new StringReader(@"
4
12345
31203
2123
2300
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var s = Console.ReadLine();
		Console.WriteLine( int.Parse(string.Join("",s.Reverse().ToArray()).ToString()));
	}
}

