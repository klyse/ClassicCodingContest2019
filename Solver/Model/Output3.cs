using System;
using System.Collections.Generic;
using System.Linq;

namespace Solver.Model
{
	public class Output3
	{
        public class Location 
        {
            public int X { get; set; }
            public int Y { get; set; }

        }

        public Dictionary<int, Location> Capital { get; set; } = new Dictionary<int, Location>();

		public override string ToString()
		{
			return string.Join(Environment.NewLine, Capital.OrderBy(c => c.Key).Select(q => $"{q.Value.X} {q.Value.Y}"));

        }
	}
}