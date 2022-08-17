<Query Kind="Program" />

// https://www.codechef.com/submit/CSTOCK
void Main()
{
	Console.SetIn(new StringReader(@"
3
100 93 108 7
100 94 100 -7
183 152 172 -17	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		var s = n[0];
		var a = n[1];
		var b = n[2];
		var c = n[3];
		
		var sc = s + (1.0 * c * s / 100);
		
		Console.WriteLine( ( sc >= a && sc <= b)? "YES" : "NO");		
	}
}

