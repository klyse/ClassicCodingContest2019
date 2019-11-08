using System.Collections.Generic;
using System.Linq;
using NeoMatrix;
using Solver.Base;

namespace Solver.Model
{
	public class TerrainInput3 : IInput<TerrainInput3>
	{
		public class Cell
		{
			public int Altitude { get; set; }
			public int Country { get; set; }

			public int Row { get; set; }
			public int Col { get; set; }

			public Dictionary<int, int> Distances { get; set; } = new Dictionary<int, int>();
		}


		public Matrix<Cell> Matrix;

		public TerrainInput3 Parse(string[] values)
		{
			var val = values.First().Split(' ').Select(q => int.Parse(q)).ToList();

			Matrix = new Matrix<Cell>(val[1], val[0]);

			var row = 0;
			foreach (var item in values.Skip(1))
			{
				var col = 0;
				var rowData = item.Split(' ').Select(q => int.Parse(q)).ToList();
				for (int i = 0; i < rowData.Count; i = i + 2)
				{
					Matrix[row, col] = new Cell
									   {
										   Altitude = rowData[i], Country = rowData[i + 1],
										   Col = col,
										   Row = row
									   };
					col++;
				}

				row++;
			}

			return this;
		}
	}
}