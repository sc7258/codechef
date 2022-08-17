<Query Kind="Program" />

// https://www.codechef.com/submit/MXEVNSUB
void Main()
{
	Console.SetIn(new StringReader(@"
3
3
4
10	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		//var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		var n = int.Parse(Console.ReadLine());
		
		var sum = Enumerable.Range(1, n).Sum().Dump("sum");
		//Console.WriteLine((sum % 2 == 0)? n : (n % 2 == 0)? n-2 : n-1);
		Console.WriteLine((sum % 2 == 0)? n : n-1);
	}
}

