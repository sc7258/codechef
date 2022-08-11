<Query Kind="Program" />

// https://www.codechef.com/submit/TVDISC
void Main()
{
	Console.SetIn(new StringReader(@"
3
85 75 35 20
100 99 0 0
30 40 0 10	
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	for (int i = 0; i < t; i++)
	{
		var n = Console.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
		var a = n[0];	//rupees
		var b = n[1];	//rupees	
		var c = n[2];	//a discount
		var d = n[3];	//b discount
		
		var v = (a-c)-(b-d);
		if(v > 0){
			Console.WriteLine("Second");
		}
		else if( v < 0){
			Console.WriteLine("First");
		}
		else{
			//v == 0
			Console.WriteLine("Any");
		}
	}
}

