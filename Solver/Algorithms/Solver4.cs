using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Solver.Base;
using Solver.Model;

namespace Solver.Algorithms
{
	public class Solver4 : ISolver<Output4, TerrainInput4>
	{
		public Output4 Solve(TerrainInput4 input)
		{
			var o = new Output4();

			foreach (var ray in input.Data)
			{
				var m = (ray.Start.Y - (ray.Start.Y + ray.Direction.Y)) / (ray.Start.X - (ray.Start.X + ray.Direction.X));
			}


			return o;
		}
	}
}