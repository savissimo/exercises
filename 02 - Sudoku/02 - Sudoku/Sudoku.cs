using System;

namespace _02___Sudoku
{
	public class Sudoku
	{
		private SudokuCell[,] m_state = new SudokuCell[9,9];

		public Sudoku(string i_state)
		{
			if (i_state.Length != 81)
			{
				throw new ArgumentException("The input string must be 81 characters long.");
			}

			for (int i = 0; i < 9; ++i)
			{
				for (int j = 0; j < 9; ++j)
				{
					char cell = i_state[i * 9 + j];
					int? digit = cell != '-' ? int.Parse(new string(cell, 1)) : (int?)null;
					m_state[i, j] = new SudokuCell(digit, true);
				}
			}
		}

		public SudokuCell this[int i, int j]
		{
			get { return m_state[i, j]; }
			set { m_state[i, j] = value; }
		}

		public bool IsSolved
		{
			get
			{
				for (int i = 0; i < 9; ++i)
				{
					for (int j = 0; j < 9; ++j)
					{
						if (m_state[i,j].Value == null)
						{
							return false;
						}
					}
				}

				for (int i = 0; i < 9; ++i)
				{
					for (int j = 0; j < 9; ++j)
					{
						for (int i2 = 0; i2 < 9; ++i2)
						{
							if (m_state[i2, j] == m_state[i, j] && i2 != i)
							{
								return false;
							}
						}

						for (int j2 = 0; j2 < 9; ++j2)
						{
							if (m_state[i, j2] == m_state[i, j] && j2 != j)
							{
								return false;
							}
						}
					}
				}

				for (int si = 0; si < 9; si += 3)
				{
					for (int sj = 0; sj < 9; sj += 3)
					{
						for (int i = 0; i < 3; ++i)
						{
							for (int j = 0; j < 3; ++j)
							{
								for (int i2 = 0; i2 < 3; ++i2)
								{
									for (int j2 = 0; j2 < 3; ++j2)
									{
										if (m_state[si + i, sj + j] == m_state[si + i2, sj + j2] && (i2 != i || j2 != j))
										{
											return false;
										}
									}
								}
							}
						}
					}
				}

				return true;
			}
		}
	}
}
