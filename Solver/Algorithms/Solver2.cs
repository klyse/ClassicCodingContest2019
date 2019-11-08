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
										TerrainInput2.Value[] adjVal = new TerrainInput2.Value[4];

										if (row > 0)
											adjVal[0] = input.Data.GetAbove(row, col);

										if (row < input.Data.Rows)
											adjVal[1] = input.Data.GetBelow(row, col);

										if (col > 0)
											adjVal[2] = input.Data.GetLeft(row, col);

										if (col < input.Data.Columns)
											adjVal[3] = input.Data.GetRight(row, col);

										foreach (var v in adjVal)
										{
											if (v is {} && v.Country != value.Country)
											{
												o.NrOfNeighbors[value.Country]++;
												break;
											}
										}
									});

			return o;
		}
	}
}