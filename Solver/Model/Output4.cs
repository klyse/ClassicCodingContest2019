using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Solver.Model
{
	public class Output4
	{
		public List<List<Point>> Coords { get; set; } = new List<List<Point>>();

		public override string ToString()
		{
            var sb = new StringBuilder();
            foreach (var item in Coords)
            {
                sb.AppendLine(string.Join(" ", item.Select(q => $"{q.X} {q.Y}")));
            }


            return sb.ToString();
		}
	}
}