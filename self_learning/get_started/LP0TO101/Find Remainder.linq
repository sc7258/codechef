<Query Kind="Program" />

//https://www.codechef.com/LP0TO101/problems/FLOW002
void Main()
{
	// inputs
	Console.SetIn(new StringReader(@"
	3 
	1 2
	100 200
	40 15
	".Trim()));


	var t = int.Parse(Console.ReadLine());// count
	for( int i= 0; i < t ; i++)
	{
		var s = Console.ReadLine().Split(' ');
		//var a = int.Parse(s[0]); //  value
		//var b = int.Parse(s[1]); //  devider
		
		Console.WriteLine( int.Parse(s[0]) % int.Parse(s[1]));
	};
}

