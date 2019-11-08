using System.Linq;
using Solver.Base;
using Solver.Model;

namespace Solver.Algorithms
{
	public class Solver2 : ISolver<Output2, TerrainInput2>
	{
		public Output2 Solve(TerrainInput2 input)
		{
			var o = new Output2();
			var countries = input.Data.GetFlat().Select(c => c.Country).Distinct().ToList();
			countries.ForEach(c => o.NrOfNeighbors.Add(c, 0));

			input.Data.ExecuteOnAll((value, row, col) =>
									{
										if (row > 1)
										{
											var above = input.Data.GetAbove(row, col);
											if (above.Country != value.Country)
												o.NrOfNeighbors[value.Country]++;
										}
									});

			return o;
		}
	}
}