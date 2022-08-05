<Query Kind="Program" />

//https://www.codechef.com/getting-started
//https://www.codechef.com/problems-old/FLOW001?itm_medium=getting-started&itm_campaign=page
public static void Main()
{
	int t = int.Parse(Console.ReadLine());
	for( int i = 0; i < t; i++ )
	{
		string[] s = Console.ReadLine().Split(" ");
		Console.WriteLine( int.Parse(s[0]) + int.Parse(s[1]));
	}
}

//public static void Main()
//{
//	int t = getCount();
//	for(int i = 0 ; i < t; i ++){
//		(int a, int b)  = getValues();	
//		
//		//write
//		Console.WriteLine( a + b);
//	}	
//}
//
//
//public static int getCount(){
//	string s = Console.ReadLine();
//	
//	//TODO exception
//	return int.Parse(s);
//}
//
//public static (int a, int b) getValues()
//{
//	string[] s = Console.ReadLine().Split(" ");
//	
//	//TODO exception
//	int a = int.Parse(s[0]);
//	int b = int.Parse(s[1]);
//	
//	return (a, b);
//}
//