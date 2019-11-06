using System;
using System.Linq;
using Solver.Base;

namespace Solver.Model
{
	public class RoverInput2 : IInput<RoverInput2>
	{
		public double WheelBase { get; set; }
		public double Distance { get; set; }
		public double SteeringAngle { get; set; }

		public double TurnRadius => Math.Round(WheelBase / Math.Sin(SteeringAngle.ToRad()), 2);

		public RoverInput2 Parse(string[] values)
		{
			var val = values.First().Split(' ');
			WheelBase = double.Parse(val.First());
			Distance = double.Parse(val.Skip(1).First());
			SteeringAngle = double.Parse(val.Skip(2).First());

			return this;
		}
	}
}