<Query Kind="Expression" />

// https://www.codechef.com/submit/DIFFMED
void Main()
{
	Console.SetIn(new StringReader(@"
2
2
3
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
	}
}