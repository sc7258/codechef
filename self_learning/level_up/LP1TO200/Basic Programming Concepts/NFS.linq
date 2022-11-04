<Query Kind="Program" />

// https://www.codechef.com/submit/NFS

//using system.linq
void Main()
{
	Console.SetIn(new StringReader(@"
3
1 1 1 1
2 1 1 1
2 2 1 1
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var d = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		var u = d[0];   //?? velocity m/s
		var v = d[1];   //?? velocity max
		var a = d[2];   //?? velocity min
		var s = d[3];   //?? s meter
		
		var r = (v*v) - (u*u -2*a*s);
		
		r.Dump();
		
		Console.WriteLine( r >= 0 ? "Yes" : "No");
	}
}

