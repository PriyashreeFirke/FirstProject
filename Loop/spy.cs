using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Loop
{
	class spy
	{
		static void Main(string[] args)
		{
			Console.WriteLine("enter input");
			int input = int.Parse(Console.ReadLine());
			int digit; int sum = 0; int product = 1;
			while (input > 0)
			{
				digit = input % 10;
				sum = sum + digit;

				product = product * digit;
				input = input / 10;
			}
				Console.WriteLine("sum of number" + sum);
				Console.WriteLine("product of number" + product);
				if (sum == product)
				{
					Console.WriteLine("input is spy number");

				}
				else
				{
					Console.WriteLine("input is not spy number");
				}

			}
		}
	}

