<Query Kind="Program" />

//https://www.codechef.com/submit/SPLITN
void Main()
{
	Console.SetIn(new StringReader(@"
2
3
4	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var n = int.Parse(Console.ReadLine());
		
		//?? number of one in binary
		string binary = Convert.ToString(n, 2)
		//.Dump()
		;
		Console.WriteLine(binary.Where(c => c == '1').Count() -1);
	}
}

