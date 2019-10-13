using System;
using System.Linq;
using Solver.Base;

namespace Solver.Model
{
	public class RoverInput1 : IInput<RoverInput1>
	{
		public double WheelBase { get; set; }
		public double SteeringAngle { get; set; }

		public RoverInput1 Parse(string[] values)
		{
			WheelBase = double.Parse(values.First());
			SteeringAngle = double.Parse(values.Skip(1).First());

			return this;
		}
	}
}