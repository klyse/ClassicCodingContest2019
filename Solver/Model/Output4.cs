using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Solver.Model
{
	public class Output4
	{
		public Dictionary<int, Point> Capital { get; set; } = new Dictionary<int, Point>();

		public override string ToString()
		{
			return string.Join(Environment.NewLine, Capital.OrderBy(c => c.Key).Select(q => $"{q.Value.X} {q.Value.Y}"));
		}
	}
}