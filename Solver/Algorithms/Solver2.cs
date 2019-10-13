using System;
using Solver.Model;

namespace Solver.Algorithms
{
	public class Solver2 : ISolver<double, RoverInput2>
	{
		public double Solve(RoverInput2 input)
		{
			var angle = input.Distance / input.TurnRadius;
		}
	}
}