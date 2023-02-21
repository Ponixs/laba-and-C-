using System;


namespace Part_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write($"Program №1:");
			number1();
			Console.Write($"\nProgram №2:\n");
			number2();
		}

		static int number1()
		{
			int max = 200;
			string userString = Console.ReadLine();
			int intValue = Convert.ToInt32(userString);
			if ((intValue > 50) || (intValue < 0)) return -1;

			for (int i = 1; i < max; i++)
			{
				if (intValue == find_divisor(i))
				{
					Console.Write($"{i}\t");
				}
			}
			return 0;
		}

		private static int find_divisor(int div)
		{
			if (div == 1 || div == -1) return 1;
			int count = 2;
			for (int i = 2; i <= (int)Math.Sqrt(div); i++) if (div % i == 0) count += 2;
			if (((int)Math.Sqrt(div) == Math.Sqrt(div)) && (div % (int)Math.Sqrt(div) == 0)) count--;
			return count;
		}

		static void number2()
		{
			for (int i = 1; i < 20; i++)
            {
                for (int j = 1; j < 20; j++)
                {
                    for (int k = 1; k < 20; k++)
                    {
                        if ((i + j * j)== (k * k))
						{
							Console.WriteLine($"{i} {j} {k}");
						}

					}
                }
            }
		}
	}
}
