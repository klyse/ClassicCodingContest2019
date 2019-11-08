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

        public List<Ray> Rays;



        public TerrainInput4 Parse(string[] values)
        {
            var val = values[0].Split(' ').Select(q => int.Parse(q)).ToList();
            Rows = val[0];
            Cols = val[1];

            Rays = new List<Ray>();

            var n = int.Parse(values[1]);

            for (int i = 0; i < n; i++)
            {
                val = values[2 + i].Split(' ').Select(q => int.Parse(q)).ToList();
                Rays.Add(new Ray { Start = new Point(val[0], val[1]), Direction = new Point(val[2], val[3]) });
            }

            return this;
        }
    }
}