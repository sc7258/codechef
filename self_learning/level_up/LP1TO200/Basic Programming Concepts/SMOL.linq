<Query Kind="Program" />

// https://www.codechef.com/submit/SMOL
// using System.Linq;
void Main()
{
	Console.SetIn(new StringReader(@"
3
5 2
4 4
2 5	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var d = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		
		var n = d[0];
		var k = d[1];
		while ((n = n - k) >= 0) ;

		Console.WriteLine(n < 0 ? n + k : n);
	}
}

