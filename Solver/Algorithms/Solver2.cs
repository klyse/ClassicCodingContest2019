using System;
using Solver.Base;
using Solver.Model;

namespace Solver.Algorithms
{
	public class Position
	{
		public double X { get; set; }
		public double Y { get; set; }
		public double Angle { get; set; }

		public Position(double x, double y, double angle)
		{
			X = x;
			Y = y;
			Angle = angle;
		}

		public override string ToString()
		{
			return $"{X:00} {Y:00} {Angle:00}";
		}
	}

	public class Solver2 : ISolver<Position, RoverInput2>
	{
		public Position Solve(RoverInput2 input)
		{
			var alpha = input.Distance / input.TurnRadius;


			var x = Math.Round(input.TurnRadius * Math.Cos(alpha), 2);
			var y = Math.Round(input.TurnRadius * Math.Sin(alpha), 2);

			return new Position(x, y, 0);
		}
	}
}