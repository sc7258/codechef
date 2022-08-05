<Query Kind="Program" />

//https://www.codechef.com/LP0TO101/problems/FLOW001
void Main()
{
	//set data
	Console.SetIn(new StringReader(@"
3
1 2
100 200
10 40	
	".Trim()));
	
	//logic	
	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var s = Console.ReadLine().Split(' ');
		//var a = int.Parse(s[0]);
		//var b = int.Parse(s[1]);
		
		Console.WriteLine( int.Parse(s[0]) + int.Parse(s[1]));
	}
	
}

