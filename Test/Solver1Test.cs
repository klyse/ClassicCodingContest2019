using System;
using System.IO;
using GoogleHashCode2019;
using NUnit.Framework;
using Solver.Algorithms;
using Solver.Base;
using Solver.Model;

namespace Test
{
	public class Solver1Test
	{
		[Test]
		public void T1()
		{
			var x = EnvironmentConstants.DataPath;
			var solution = new Solver1().Solve(new RoverInput1().Parse(new[] { "1 30" }));
			Assert.AreEqual(2, solution);
		}
	}
}