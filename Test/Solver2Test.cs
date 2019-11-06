using NUnit.Framework;
using Solver.Algorithms;
using Solver.Model;

namespace Test
{
	public class Solver2Test
	{
		[Test]
		[TestCase("1,00 1,00 30,00", ExpectedResult = "12")]
		public string T1(string inputStr)
		{
			var solver = new Solver2();
			var input = new RoverInput2().Parse(new[] { inputStr });
			var solution = solver.Solve(input);

			return solution.ToString();
		}
	}
}