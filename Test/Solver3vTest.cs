using System;
using NUnit.Framework;
using Solver;
using Solver.Algorithms;
using Solver.Model;

namespace Test {
	public class Solver3vTest
	{
		[Test]
		[TestCase("Level3/level3_example.in")]
		[TestCase("Level3/level3_1.in")]
		[TestCase("Level3/level3_2.in")]
		[TestCase("Level3/level3_3.in")]
		[TestCase("Level3/level3_4.in")]
		[TestCase("Level3/level3_5.in")]
		public void T1(string file)
		{
			var fileInput = file.Read();
			var input = new TerrainInput3().Parse(fileInput);

			var solution = new Solver3v().Solve(input);

			file.Write(solution.ToString());
			Console.WriteLine(solution);
			Assert.Pass();
		}
	}
}