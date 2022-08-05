<Query Kind="Program" />

//https://www.codechef.com/LP0TO101/problems/INTEST

void Main()
{
	//setdata
	Console.SetIn(new StringReader(@"
7 3
1
51
966369
7
9
999996
11
	".Trim())
	);
	
	
	//
	var s = Console.ReadLine().Split(' ');
	var n = int.Parse(s[0]);
	var k = int.Parse(s[1]);
	
	var ans = 0;
	for(int i = 0; i < n; i++){
		var t = int.Parse(Console.ReadLine());
		if(t % k == 0) ++ans;
	}
	
	Console.WriteLine(ans);
	
}




//void Main()
//{
//	//read input - n, k
//	(int n, int k) =  readInputNK();
//	
//	//read input - t[]
//	int[] t = readInputT();
//	
//	
//	//validation check
//	Debug.Assert( n == t.Length);
//	
//	//find divided number count
//	int ans =  getDividedCount(k, t);
//	
//	Console.WriteLine(ans);	
//}
//
//int getDividedCount(int divider, int[] values)
//{
//	int count = 0;
//	for( int i = 0; i < values.Length; i++)
//	{
//		if( values[i] % divider == 0) ++count;
//	}
//	
//	return count;
//}
//
//(int n, int k) readInputNK(){
//	string s;
//	while( !string.IsNullOrEmpty( s = Console.ReadLine()))
//	{
//		var values = s.Split(" ");
//		//Debug.Assert( values.Length == 2);
//
//		if(values.Length >= 2)
//		{
//			try
//			{
//				int n = Convert.ToInt32(values[0]);
//				int k = Convert.ToInt32(values[1]);
//				
//				if(n > 10000000 || k > 10000000){
//					throw new Exception($"invalid input 'n:{n}', 'k:{k}'");
//				}
//
//				return ( n, k);
//			}
//			catch (FormatException)
//			{
//				Console.WriteLine($"Unable to parse '{values}'");
//			}
//		}		
//	}	
//	
//	return (-1, -1);
//}
//
//int[] readInputT(){
//	List<int> n = new List<int>();
//	
//	string s;
//	while( !string.IsNullOrEmpty( s = Console.ReadLine()))
//	{
//		var t = int.Parse(s);	
//		n.Add(t);
//	}	
//	
//	return n.ToArray();
//}