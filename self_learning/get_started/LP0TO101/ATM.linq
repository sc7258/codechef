<Query Kind="Program" />

// https://www.codechef.com/LP0TO101/problems/HS08TEST
void Main()
{

	Console.SetIn(new StringReader(@"
42 120.00
300 120.00
30 120.00
	".Trim()));
	
	var s = Console.ReadLine().Split(' ');
	var x = float.Parse(s[0]);
	var y = float.Parse(s[1]);
	var r = y - x - 0.5;
	
	if (x <= 0 || x > 2000) 
		Console.WriteLine(y.ToString(".00"));

	else if (y < 0 || x > 2000)
		Console.WriteLine(y.ToString(".00"));

	else if( x / 5.0 != ((int)x) / 5 )
		Console.WriteLine(y.ToString(".00"));

	else if (r >= 0 )
		Console.WriteLine(r.ToString(".00"));
	else
		Console.WriteLine(y.ToString(".00"));
}

