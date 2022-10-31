using System;

namespace Pay
{
 
		public class Program        
		{
			public static void Main(string[] args)      
			{
				
				Console.WriteLine("Enter the number of hours worked");
				int hoursWorked = int.Parse(Console.ReadLine());

				Console.WriteLine($"The calculated Net pay is ${CalculateNetPay(hoursWorked)}");
			}

			
			public static double GetGrossPay(int hoursworked)
			{
				double grossPay;

				if (hoursworked < 56)
					grossPay = hoursworked * 80;
				else
				{
					int extraHours = hoursworked - 56;
					grossPay = (extraHours * 1.5 * 80) + (hoursworked * 80);
				}

				return grossPay;
			}

			public static double CalculateTax(double grossPay)
			{
				double deductableTax;

				deductableTax = grossPay * 0.02;

				return deductableTax;
			}

			public static double CalculateNetPay(int hoursWorked)
			{
				double netPay, grossPay, deductableTax;

				grossPay = GetGrossPay(hoursWorked);
				deductableTax = CalculateTax(grossPay);
				netPay = grossPay - deductableTax;

				return netPay;
			}
		}
	}