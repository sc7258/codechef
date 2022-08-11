<Query Kind="Program" />

// https://www.codechef.com/submit/POPULATION
void Main()
{
	Console.SetIn(new StringReader(@"
4
3 1 2
2 2 2
4 1 8
10 1 10
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		//var x = n[0];// initial
		//var y = n[1];// left
		//var z = n[2];// immigrated
		
		Console.WriteLine( n[0] - n[1] + n[2]);
	}
}

