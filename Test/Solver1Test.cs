using NUnit.Framework;
using Solver;
using Solver.Algorithms;
using Solver.Model;

namespace Test
{
	public class Solver1Test
	{
		[Test]
		[TestCase("Level1/level1_example.in")]
		[TestCase("Level1/level1_1.in")]
		[TestCase("Level1/level1_2.in")]
		[TestCase("Level1/level1_3.in")]
		[TestCase("Level1/level1_4.in")]
		[TestCase("Level1/level1_5.in")]
		public void T1(string file)
		{
			var fileInput = file.Read();
			var input = new TerrainInput1().Parse(fileInput);

			var solution = new Solver1().Solve(input);

			file.Write(solution.ToString());
			Assert.Pass();
		}
	}
}