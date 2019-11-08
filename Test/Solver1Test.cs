using NUnit.Framework;
using Solver;
using Solver.Algorithms;
using Solver.Model;

namespace Test
{
	public class Solver1Test
	{
		[Test]
		[TestCase("New Text File.txt")]
		public void T1(string file)
		{
			var fileInput = file.Read();
			var input = new RoverInput1().Parse(fileInput);

			var solution = new Solver1().Solve(input);

			file.Write(solution);
			Assert.Pass();
		}
	}
}