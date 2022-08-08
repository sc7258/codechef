<Query Kind="Program" />

// https://www.codechef.com/LP0TO101/problems/FLOW004
void Main()
{
	// inputs
	Console.SetIn(new StringReader(@"
3 
1234
124894
242323
	".Trim()));

	var t = int.Parse(Console.ReadLine());// count
	for (int i = 0; i < t; i++)
	{
		var s = Console.ReadLine();
		//Console.WriteLine(int.Parse($"{s[0]}") + int.Parse($"{s[s.Length -1]}"));
		Console.WriteLine(int.Parse(s[0].ToString()) + int.Parse(s[s.Length -1].ToString()));
	}
}

