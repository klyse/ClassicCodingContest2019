using NUnit.Framework;
using Solver;
using Solver.Algorithms;
using Solver.Model;

namespace Test {
	public class Solver2Test
	{
		[Test]
		[TestCase("Level2/level2_example.in")]
		[TestCase("Level2/level2_1.in")]
		[TestCase("Level2/level2_2.in")]
		[TestCase("Level2/level2_3.in")]
		[TestCase("Level2/level2_4.in")]
		[TestCase("Level2/level2_5.in")]
		public void T1(string file)
		{
			var fileInput = file.Read();
			var input = new TerrainInput2().Parse(fileInput);

			var solution = new Solver2().Solve(input);

			file.Write(solution.ToString());
			Assert.Pass();
		}
	}
}