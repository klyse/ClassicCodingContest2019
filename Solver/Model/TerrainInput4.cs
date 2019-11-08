using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NeoMatrix;
using Solver.Base;

namespace Solver.Model
{
	public class TerrainInput4 : IInput<TerrainInput4>
	{
        public class Ray
        {
            public Point Start;
            public Point Direction;
        }


        public int Rows;
        public int Cols;

        public List<Ray> Data;



        public TerrainInput4 Parse(string[] values)
        {
            /*
            var val = values.First().Split(' ').Select(q => int.Parse(q)).ToList();

            Matrix = new Matrix<Cell>(val[1], val[0]);

            var row = 0;
            foreach (var item in values.Skip(1))
            {
                var col = 0;
                var rowData = item.Split(' ').Select(q => int.Parse(q)).ToList();
                for (var i = 0; i < rowData.Count; i = i + 2)
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
        */
			return this;
		}
	}
}