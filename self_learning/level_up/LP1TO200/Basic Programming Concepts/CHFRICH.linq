<Query Kind="Program">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

//https://www.codechef.com/submit/CHFRICH
void Main()
{
	Console.SetIn(new StringReader(@"
3
100 200 10
111 199 11
190 200 10
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var s = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		
		if(( s[1] - s[0] >= 0) && s[2] > 0){
			var ans = (s[1] - s[0]) / s[2];
			Console.WriteLine( (s[1] - s[0]) % s[2] == 0 ? ans : ans +1);
		}
	}
}

