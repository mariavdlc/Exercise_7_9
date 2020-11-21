/*This program calculates how many numbers of 1,2,3 or
 * more digits are entered by the user until he/she types
 * "end"*/
using System;
class digits
{
	static void Main()
	{
		int OneDigit = 0, TwoDigit = 0, ThreeDigit = 0, MoreDigit = 0, 
			number;
		string CheckNumber;
		
		Console.Write("Insert a number, insert end for exit: ");
		CheckNumber = Console.ReadLine();
		
		while(CheckNumber != "end")
		{
			number = Convert.ToInt32(CheckNumber);
			
			if(number/10 == 0)
				OneDigit++;
			else
				if(number/100 == 0)
					TwoDigit++;
				else
					if(number/1000 == 0)
						ThreeDigit++;
					else
						MoreDigit++;
						
			CheckNumber = Console.ReadLine();
		}
		
		Console.WriteLine("One: {0}, Two: {1}, Three: {2} or more: {3}",
			OneDigit, TwoDigit, ThreeDigit, MoreDigit);
	}
}
