namespace _02___Sudoku
{
	public class SudokuCell
	{
		private int? m_value = null;
		private bool m_isFixed = false;

		public SudokuCell(int? i_value, bool i_isFixed = false)
		{
			m_value = i_value;
			m_isFixed = i_isFixed;
		}

		public int? Value
		{
			get { return m_value; }
			set
			{
				if (!m_isFixed)
				{
					m_value = value;
				}
			}
		}

		public bool IsFixed
		{
			get { return m_isFixed; }
		}

		public static bool operator==(SudokuCell one, SudokuCell other)
		{
			return one.Value != null && other.Value != null && other.Value == one.Value;
		}

		public static bool operator!=(SudokuCell one, SudokuCell other)
		{
			return one.Value == null || other.Value == null || other.Value != one.Value;
		}
	}
}
