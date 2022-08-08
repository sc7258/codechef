<Query Kind="Program" />

//https://www.codechef.com/LP0TO101/problems/FLOW013
void Main()
{
	Console.SetIn(new StringReader(@"
3
40 40 100
45 45 90
180 1 1	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var s = Console.ReadLine().Split(' ');	
		
		Console.WriteLine( (int.Parse(s[0]) + int.Parse(s[1]) + int.Parse(s[2])) == 180 ? "YES" : "NO");
	}
}

