/*This program calculates the average of a 
set of marks, until the user types “end”.*/
using System;
public class Average
{
	public static void Main()
	{
		double addition = 0, numberMark, result=0;
		int counter = 0;
		string mark;	
		
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine(); 
		
		while (mark != "end")
		{  
			numberMark = Convert.ToDouble(mark);
			counter++;   
			addition += numberMark;  
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}
		
		if (counter != 0)
		{
			result = addition/counter;  
		}
		
		Console.WriteLine("The average is {0}.",result);
	}
}