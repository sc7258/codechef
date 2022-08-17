<Query Kind="Program" />

// https://www.codechef.com/submit/MAX_DIFF
void Main()
{
	Console.SetIn(new StringReader(@"
3
3 1
4 4
2 3	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var d = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		var n = d[0];	//?? max
		var s = d[1];	//?? sum
		
		var min = s - n;
		
		//s.Dump("sum");
		//n.Dump("max");
		//min.Dump("min");
		
		Console.WriteLine(Math.Abs(n) -Math.Abs(min));
	}
}

