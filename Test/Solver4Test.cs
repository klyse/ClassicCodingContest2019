using System;
using NUnit.Framework;
using Solver;
using Solver.Algorithms;
using Solver.Model;

namespace Test
{
	public class Solver4Test
	{
		[Test]
		[TestCase("Level4/Level4_example.in")]
		[TestCase("Level4/Level4_1.in")]
		[TestCase("Level4/Level4_2.in")]
		[TestCase("Level4/Level4_3.in")]
		[TestCase("Level4/Level4_4.in")]
		[TestCase("Level4/Level4_5.in")]
		public void T1(string file)
		{
			var fileInput = file.Read();
			var input = new TerrainInput4().Parse(fileInput);

			var solution = new Solver4().Solve(input);

			file.Write(solution.ToString());
			Console.WriteLine(solution);
			Assert.Pass();
		}
	}
}