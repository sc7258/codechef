<Query Kind="Program" />

// https://www.codechef.com/submit/MANYSUMS
void Main()
{
	Console.SetIn(new StringReader(@"
2
2 2
2 3
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		var l = n[0];
		var r = n[1];
		
		var ans = (
			from a in Enumerable.Range(l, r-l+ 1)
			from b in Enumerable.Range(l, r-l+ 1)
			select a + b
		)
		.Distinct()
		//.ToArray()
		//.Dump()
		.Count()
		;
		
		Console.WriteLine(ans);	
		
	}
	
	
}

