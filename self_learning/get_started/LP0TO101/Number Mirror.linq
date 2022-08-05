<Query Kind="Program" />

//https://www.codechef.com/LP0TO101/problems/START01
void Main()
{
	int[] n = getInputN();
	writeN(n);
}

void writeN(int[] n){
	foreach (var v in n)
	{
		Console.WriteLine(v);
	}
}

int[] getInputN()
{
	List<int> n = new List<int>();
	string line;
	while (!string.IsNullOrEmpty(line = Console.ReadLine()))
	{
		try
		{
			int value = Int32.Parse(line);
			if (value >= 0 && value <= 100000)
			{
				n.Add(value);
			}
		}
		catch (FormatException)
		{
			Console.WriteLine($"Unable to parse '{line}'");
		}
	}
	
	return n.ToArray();
}