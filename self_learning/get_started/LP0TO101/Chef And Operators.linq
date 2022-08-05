<Query Kind="Program" />

//https://www.codechef.com/LP0TO101/problems/CHOPRT
void Main()
{
	//setdata
	Console.SetIn(new StringReader(	@"
3
10 20
20 10
10 10	
	".Trim())	
	);
	
	//logics
	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var s = Console.ReadLine().Split(' ');
		var a = int.Parse(s[0]);
		var b = int.Parse(s[1]);

		var ans = a > b ? '>' : a < b? '<' : '=';
		Console.WriteLine(ans);
	}
	
}

