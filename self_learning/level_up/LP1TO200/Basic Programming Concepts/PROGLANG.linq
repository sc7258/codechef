<Query Kind="Program">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

// https://www.codechef.com/submit/PROGLANG
//using System.Linq;
void Main()
{
	Console.SetIn(new StringReader(@"
3
1 2 2 1 3 4
3 4 2 1 4 3
1 2 1 3 2 4	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var d = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		//var d = int.Parse(Console.ReadLine());

		var ab = d.Take(2);
		var ab1 = d.Skip(2).Take(2);
		var ab2 = d.Skip(4).Take(2);

		if (ab.Where(x => ab1.Contains(x)).Count() == 2)
			Console.WriteLine("1");

		else if (ab.Where(x => ab2.Contains(x)).Count() == 2)
			Console.WriteLine("2");
			
		else 
			Console.WriteLine("0");
	}
}

