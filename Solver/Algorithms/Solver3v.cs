using System.Collections.Generic;
using System.Linq;
using Solver.Base;
using Solver.Model;
using System.Drawing;

namespace Solver.Algorithms
{
    public class Solver3v : ISolver<Output3, TerrainInput3>
    {


        public Output3 Solve(TerrainInput3 input)
        {
            var o = new Output3();
            var countries = input.Matrix.GetFlat().Select(c => c.Country).Distinct().ToList();
            countries.ForEach(c => o.Capital.Add(c, new Point { X = 0, Y = 0 }));

            foreach (var country in countries)
            {
                var coords = new List<Point>();

                input.Matrix.ExecuteOnAll((value, row, col) =>
                {
                    if (value.Country == country)
                        coords.Add(new Point { X = col, Y = row });
                });

                var location = new Point(coords.Select(q => q.X).Sum() / coords.Count, coords.Select(q => q.Y).Sum() / coords.Count);

                if (input.IsBorder(location))
                {
                    // Get all inside country cells
                    location = coords
                                        .Where(q => !input.IsBorder(q.Y, q.X))
                                        .Select(q => new { Location = q, Distance = input.Distance(location, q) })
                                        .OrderBy(q => q.Distance).ThenBy(q => q.Location.Y).ThenBy(q => q.Location.X)
                                        .Select(q => q.Location).First();
                }

                o.Capital[country] = location;
            }

            return o;
        }
    }
}