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
			var countries = input.Matrix.GetFlat().Select(c => c.Country).Distinct().ToList();
			countries.ForEach(c => o.NrOfNeighbors.Add(c, 0));

			input.Matrix.ExecuteOnAll((value, row, col) =>
									{
										var adjVal = new TerrainInput2.Cell[4];

										if (row > 0)
											adjVal[0] = input.Matrix.GetAbove(row, col);

										if (row < input.Matrix.Rows - 1)
											adjVal[1] = input.Matrix.GetBelow(row, col);

										if (col > 0)
											adjVal[2] = input.Matrix.GetLeft(row, col);

										if (col < input.Matrix.Columns - 1)
											adjVal[3] = input.Matrix.GetRight(row, col);

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