using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Solver.Base;
using Solver.Model;

namespace Solver.Algorithms
{
	public class Solver3 : ISolver<Output3, TerrainInput3>
	{
		public Output3 Solve(TerrainInput3 input)
		{
			var o = new Output3();
			var countries = input.Matrix.GetFlat().Select(c => c.Country).Distinct().ToList();
			countries.ForEach(c => o.Capital.Add(c, Point.Empty));

			input.Matrix.ExecuteOnAll((value, row, col) =>
									  {
										  countries.ForEach(c => value.Distances.Add(c, 0));

										  input.Matrix.ExecuteOnAll((cell, row1, col1) =>
																	{
																		if (row1 == row && col1 == col)
																			return;

																		var yDist = Math.Abs(row - row1);
																		var xDist = Math.Abs(col - col1);

																		var dist = (int)Math.Sqrt(yDist ^ 2 + xDist ^ 2);

																		value.Distances[cell.Country] += dist;
																	});
									  });

			foreach (var country in countries)
			{
				var pList = input.Matrix.GetFlat().Where(c => c.Country == country).OrderBy(c => c.Distances[country]).ToList();
				var p = pList.First();
				o.Capital[country] = new Point(p.Col, p.Row);
			}

			return o;
		}
	}
}