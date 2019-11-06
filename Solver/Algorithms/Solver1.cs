using System;
using Solver.Base;
using Solver.Model;

namespace Solver.Algorithms
{
	public class Solver1 : ISolver<double, RoverInput1>
	{
		public double Solve(RoverInput1 input)
		{
			return Math.Round(input.WheelBase / Math.Sin(input.SteeringAngle.ToRad()), 2);
		}
	}
}