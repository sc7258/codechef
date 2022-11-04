<Query Kind="Program" />

// https://www.codechef.com/submit/FUNHAND
//using System.Linq;
void Main()
{
	Console.SetIn(new StringReader(@"
3
4 2 3
6 2 1
5 2 5
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var d = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		
		var n = d[0];
		var a = Math.Min(d[1],d[2]);
		var b = Math.Max(d[1],d[2]);

		if(n < 3) 
			Console.WriteLine(0);
		if(a == b)			
			Console.WriteLine(0);
		if(b -a >= 3)
			Console.WriteLine(0);

		int r = 0;
		if (b - a == 1)
		{
			if (a > 1) ++r;
			if (b < n) ++r;
			Console.WriteLine( r );
		}
		
		if (b - a == 2)
		{
			Console.WriteLine( 1 );
		}
			
	}
}

