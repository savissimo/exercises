using _02___Sudoku;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02___Test
{
	[TestClass]
	public class WorkingSudoku
	{
		[TestMethod]
		public void Creation()
		{
			Sudoku sudoku = new Sudoku("---------------------------------------------------------------------------------");
			Assert.ThrowsException<ArgumentException>(() => { Sudoku s = new Sudoku("--------------------------------------------------------------------------------"); });
			Assert.ThrowsException<ArgumentException>(() => { Sudoku s = new Sudoku("----------------------------------------------------------------------------------"); });

			sudoku = new Sudoku("123456789456789123789123456234567891567891234891234567345678912678912345912345678");
			Assert.IsTrue(sudoku.IsSolved);
		}

		[TestMethod]
		public void UnsolvedIfACellIsEmpty()
		{
			Sudoku sudoku = new Sudoku("---------------------------------------------------------------------------------");
			Assert.IsFalse(sudoku.IsSolved);
			sudoku = new Sudoku("12345678945678912378912345623456789156789123489123456734567891267891234591234567-");
			Assert.IsFalse(sudoku.IsSolved);
		}

		[TestMethod]
		public void UnsolvedIfACellIsDuplicatedInARow()
		{
			Sudoku sudoku = new Sudoku("113456789456789123789123456234567891567891234891234567345678912678912345912345678");
			Assert.IsFalse(sudoku.IsSolved);
		}

		[TestMethod]
		public void UnsolvedIfACellIsDuplicatedInAColumn()
		{
			Sudoku sudoku = new Sudoku("123456789156789123789123456234567891567891234891234567345678912678912345912345678");
			Assert.IsFalse(sudoku.IsSolved);
		}

		[TestMethod]
		public void UnsolvedIfACellIsDuplicatedInASquare()
		{
			Sudoku sudoku = new Sudoku("123456789416789123789123456234567891567891234891234567345678912678912345912345678");
			Assert.IsFalse(sudoku.IsSolved);
		}
	}
}
