using System.Linq;
using Solver.Base;
using Solver.Model;

namespace Solver.Algorithms
{
    public class Solver2v : ISolver<Output2, TerrainInput2>
    {
        public Output2 Solve(TerrainInput2 input)
        {
            var o = new Output2();

            var countries = input.Matrix.GetFlat().Select(c => c.Country).Distinct().ToList();
            countries.ForEach(c => o.NrOfNeighbors.Add(c, 0));

            for (int row = 0; row < input.Matrix.Rows; row++)
                for (int col = 0; col < input.Matrix.Columns; col++)
                {
                    var country = input.Matrix[row, col].Country;
                    var found = 0;
                    if (col > 0 && input.Matrix[row, col - 1].Country != country)
                        found++;
                    if (row > 0 && input.Matrix[row - 1, col].Country != country)
                        found++;
                    if (col < input.Matrix.Columns - 1 && input.Matrix[row, col + 1].Country != country)
                        found++;
                    if (row < input.Matrix.Rows - 1 && input.Matrix[row +1, col].Country != country)
                        found++;

                    if (found > 0)
                        o.NrOfNeighbors[country] = o.NrOfNeighbors[country] + found;
                }

            return o;
        }
    }
}