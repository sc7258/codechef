<Query Kind="Program" />

//https://www.codechef.com/LP0TO101/problems/LUCKFOUR
void Main()
{
	Console.SetIn(new StringReader(@"
5
447474
228
6664
40
81
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var s = Console.ReadLine().Select(c => int.Parse(c.ToString()));
		
		Console.WriteLine(s.Where(n => n == 4).Count());
	}
}

