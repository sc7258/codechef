<Query Kind="Program" />

// https://www.codechef.com/LP0TO101/problems/FLOW010
void Main()
{
	Console.SetIn(new StringReader(@"
4
B
c
D
e
	".Trim()));

	var t = int.Parse(Console.ReadLine());
	var dic = new Dictionary<String, String>()
		{
			{"b", "BattleShip"},
			{"c", "Cruiser"},
			{"d", "Destroyer"},
			{"f", "Frigate"},
		};

	for( int i = 0; i < t; i++ ){
		var s = Console.ReadLine().Trim();
		
		Console.WriteLine(dic[s.ToLower()]);			
	}	
}

