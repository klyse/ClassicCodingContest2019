﻿using System.Linq;
using NeoMatrix;
using Solver.Base;

namespace Solver.Model
{
	public class TerrainInput2 : IInput<TerrainInput2>
	{
        public class Value
        {
            public int Altitude { get; set; }
            public int Country { get; set; }
        }


        public Matrix<Value> Data;

		public TerrainInput2 Parse(string[] values)
		{
			var val = values.First().Split(' ').Select(q => int.Parse(q)).ToList();

			Data = new Matrix<Value>(val[1], val[0]);

            var row = 0;
            foreach (var item in values.Skip(1))
            {
                var col = 0;
                var rowData = item.Split(' ').Select(q => int.Parse(q)).ToList();
                for (int i = 0; i < rowData.Count; i = i + 2)
                {
                    Data[row, col] = new Value { Altitude = rowData[i], Country = rowData[i + 1] };
                    col++;
                }

                row++;
            }

            return this;
		}
	}
}