using Exercises___BST;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test___BST
{
	[TestClass]
	public class TreeTraversal
	{
		string input1 = "5 9 4 3 6 8 2 4";

		private Node BuildTree(string input)
		{
			string[] tokens = input.Split(" ".ToCharArray());
			Node retval = null;
			foreach (string token in tokens)
			{
				int value = int.Parse(token);
				if (retval == null)
				{
					retval = new Node(value);
					continue;
				}
				retval.InsertNode(value);
			}

			return retval;
		}

		[TestMethod]
		public void Task01_AscendingOrderTraversal()
		{
			Node tree1Root = BuildTree(input1);
			Assert.AreEqual("2 3 4 4 5 6 8 9", TreeTraverser.Traverse1_AscendingOrder(tree1Root));
		}

		[TestMethod]
		public void Task02_DescendingOrderTraversal()
		{
			Node tree1Root = BuildTree(input1);
			Assert.AreEqual("9 8 6 5 4 4 3 2", TreeTraverser.Traverse2_DescendingOrder(tree1Root));
		}

		[TestMethod]
		public void Task03_RootFirstTraversal()
		{
			Node tree1Root = BuildTree(input1);
			Assert.AreEqual("5 4 9 3 6 2 4 8", TreeTraverser.Traverse3_RootFirst(tree1Root));
		}

		[TestMethod]
		public void Task04_LeavesFirstTraversal()
		{
			Node tree1Root = BuildTree(input1);
			Assert.AreEqual("2 4 8 3 6 4 9 5", TreeTraverser.Traverse4_LeavesFirst(tree1Root));
		}
	}
}
