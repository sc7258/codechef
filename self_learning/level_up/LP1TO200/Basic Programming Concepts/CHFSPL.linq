<Query Kind="Program">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

// https://www.codechef.com/submit/CHFSPL
void Main()
{
	Console.SetIn(new StringReader(@"
3
4 2 8
10 14 18
2 2 2
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var s = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();

		int max = 0;
		for (int j = 0; j < 3; j++)
		{
			for (int k = 0; k < 3; k++)
			{
				if( j != k && max < (s[j] + s[k])){
					max = s[j] + s[k];
				}
			}
		}
		
		Console.WriteLine(max);
	}
	
	//	var t = int.Parse(Console.ReadLine());
//	for (int i = 0; i < t; i++)
//	{
//		var s = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();	
//	    
//		//? 최소값만 제거하고  add하면 될거 같은데.. 
//		var min = s.Min();		
//		//Console.WriteLine( s.Where(c =>  c > min).Sum());		
//		var s2 = s.Where(c =>  c > min).ToArray();
//		
//		switch(s2.Count())
//		{
//			case 2:
//				Console.WriteLine(s2.Sum());
//				break;
//			case 1:
//				Console.WriteLine(s2.Sum() + min);
//				break;
//			case 0:
//				Console.WriteLine(min+min);
//				break;
//
//		}		
//	}
	
	
}

