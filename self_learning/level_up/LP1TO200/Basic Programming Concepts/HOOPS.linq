<Query Kind="Program">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

// https://www.codechef.com/submit/HOOPS
void Main()
{
	Console.SetIn(new StringReader(@"
2
1
3	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		//var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		var n = int.Parse(Console.ReadLine());
		Console.WriteLine( n/2 + (n%2));
	}
}

