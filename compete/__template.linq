<Query Kind="Program" />

void Main()
{
	Console.SetIn(new StringReader(@"
3
B
c
D	
	".Trim()));
	
	var t = int.Parse(Console.ReadLine());
	for( int i = 0; i < t; i++ ){
		var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
	}	
}

