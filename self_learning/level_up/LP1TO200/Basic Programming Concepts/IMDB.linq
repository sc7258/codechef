<Query Kind="Program" />

// https://www.codechef.com/submit/IMDB
void Main()
{
	Console.SetIn(new StringReader(@"
3	
1 1
1 1
2 2
1 50
2 100
3 2
1 51
3 100
2 50	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var ts = Console.ReadLine().Split(' ').Select(c1 => int.Parse(c1)).ToArray();
		var n = ts[0];
		var x = ts[1];
		
		var max = 0;
		for (int j = 0; j < n; j++)
		{
			var d = Console.ReadLine().Split(' ').Select(c2 => int.Parse(c2)).ToArray();
			var s = d[0];
			var r = d[1];
			
			if(s <= x && r > max){
				max = r;
			}

		}
		
		Console.WriteLine(max);
	}
}

