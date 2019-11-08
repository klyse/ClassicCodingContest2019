using System.Collections.Generic;
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
			countries.ForEach(c => o.Capital.Add(c, new Output3.Location { X = 0, Y = 0 }));

			input.Matrix.ExecuteOnAll((value, row, col) =>
									  {
										  var adjVal = new List<TerrainInput3.Cell>();

										  if (row > 0)
											  adjVal.Add(input.Matrix.GetAbove(row, col));

										  if (row < input.Matrix.Rows - 1)
											  adjVal.Add(input.Matrix.GetBelow(row, col));

										  if (col > 0)
											  adjVal.Add(input.Matrix.GetLeft(row, col));

										  if (col < input.Matrix.Columns - 1)
											  adjVal.Add(input.Matrix.GetRight(row, col));

										  if (adjVal.Count < 4)
										  {
											  // o.Capital[value.Country]++;
											  return;
										  }

										  foreach (var v in adjVal)
										  {
											  if (v.Country != value.Country)
											  {
												  //  o.Capital[value.Country]++;
												  break;
											  }
										  }
									  });

			return o;
		}
	}
}