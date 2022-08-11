<Query Kind="Program" />

// https://www.codechef.com/submit/DOMINANT2
void Main()
{
	Console.SetIn(new StringReader(@"
4
5
2 2 2 2 2
4
1 2 3 4
4
3 3 2 1
6
1 1 2 2 3 4
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var n = int.Parse(Console.ReadLine());
		var a = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		
		Debug.Assert( n == a.Length);

		var g = a.GroupBy(c => c)
		.Select(t => t.Count());
		
		var max =g.Max();
		//.Dump()
		;
		
		//if(max >= (n/2)){
		if(g.Where(t => t == max).Count() == 1)
		{
			Console.WriteLine("YES");	
		}
		else
		{
			Console.WriteLine("NO");	
		}		
	}
}

