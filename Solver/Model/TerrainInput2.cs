﻿using System.Linq;
using NeoMatrix;
using Solver.Base;

namespace Solver.Model
{
	public class TerrainInput2 : IInput<TerrainInput2>
	{
		public Matrix<Cell> Matrix;

		public TerrainInput2 Parse(string[] values)
		{
			var val = values.First().Split(' ').Select(q => int.Parse(q)).ToList();

			Matrix = new Matrix<Cell>(val[1], val[0]);

			var row = 0;
			foreach (var item in values.Skip(1))
			{
				var col = 0;
				var rowData = item.Split(' ').Select(q => int.Parse(q)).ToList();
				for (var i = 0; i < rowData.Count; i = i + 2)
				{
					Matrix[row, col] = new Cell { Altitude = rowData[i], Country = rowData[i + 1] };
					col++;
				}

				row++;
			}

			return this;
		}

		public class Cell
		{
			public int Altitude { get; set; }
			public int Country { get; set; }
		}
	}
}