using _02___Sudoku;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02___Test
{
	[TestClass]
	public class SudokuSolverTest
	{
		[TestMethod]
		public void SolveWithTrialAndError()
		{
			Sudoku sudoku = new Sudoku("-2--18--43-6--------8--9-6-76---5--2---------1--2---53-7-4--3--------5-69--52--4-");
			TrialAndErrorSolver solver = new TrialAndErrorSolver();
			solver.Solve(sudoku);
			Assert.IsTrue(sudoku.IsSolved);
		}
	}
}
