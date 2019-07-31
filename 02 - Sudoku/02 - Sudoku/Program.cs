using System;

namespace _02___Sudoku
{
	public class Program
	{
		static void Main(string[] args)
		{
			string problem = null;
			if (args.Length > 0)
			{
				problem = args[0];
			}
			else
			{
				problem = Console.ReadLine();
			}

			Sudoku sudoku = new Sudoku(problem);
		}
	}
}
