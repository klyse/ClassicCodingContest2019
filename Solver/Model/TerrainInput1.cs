using System.Linq;
using Solver.Base;
using NeoMatrix;

namespace Solver.Model
{
	public class TerrainInput1 : IInput<TerrainInput1>
	{
        public Matrix<int> Data;
	
		public TerrainInput1 Parse(string[] values)
		{
			var val = values.First().Split(' ').Select(q => int.Parse(q)).ToList();

            Data = new Matrix<int>(val[1], val[0]);

			return this;
		}
	}
}