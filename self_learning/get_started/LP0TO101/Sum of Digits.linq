<Query Kind="Program" />

// https://www.codechef.com/LP0TO101/problems/FLOW006
void Main()
{
	// inputs
	Console.SetIn(new StringReader(@"
3 
12345
31203
2123
	".Trim()));
	
	var t = int.Parse(Console.ReadLine());
	for( int i = 0; i < t; i++){
		var s = Console.ReadLine().Select(c => int.Parse(c.ToString())).ToList();
		
		//Console.WriteLine( s.Aggregate (0, (acc, x) => acc+ int.Parse(x.ToString())));
		Console.WriteLine( s.Aggregate ((acc, x) => acc+ x));
		//Console.WriteLine(s.Sum());
	}
	
}

