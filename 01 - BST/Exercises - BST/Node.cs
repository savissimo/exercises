namespace Exercises___BST
{
	public class Node
	{
		public Node Left { get; set; } = null;
		public Node Right { get; set; } = null;
		public int Value { get; set; } = 0;

		public Node(int i_value)
		{
			Value = i_value;
		}

		public void InsertNode(int i_value)
		{
			if (i_value <= Value)
			{
				if (Left != null)
				{
					Left.InsertNode(i_value);
				}
				else
				{
					Left = new Node(i_value);
				}
			}
			else
			{
				if (Right != null)
				{
					Right.InsertNode(i_value);
				}
				else
				{
					Right = new Node(i_value);
				}
			}
		}
	}
}
