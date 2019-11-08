using System;
using System.Collections.Generic;
using System.Linq;

namespace Solver.Model
{
	public class Output2
	{
		public Dictionary<int, int> NrOfNeighbors { get; set; } = new Dictionary<int, int>();

		public override string ToString()
		{
			return string.Join(Environment.NewLine, NrOfNeighbors.OrderBy(c => c.Key));
		}
	}
}