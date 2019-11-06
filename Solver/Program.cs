using System;
using Solver.Algorithms;
using Solver.Model;

namespace Solver
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Classic Coding Contest 2019");

			Console.WriteLine("by: VolkmarR & Klyse");

			Console.WriteLine();
			Console.WriteLine("--------------------------");
			Console.WriteLine(new Solver1().Solve(new RoverInput1().Parse(new[] { "1", "0", "30" })));

			//var slideShowOutput = new SlideShowSolver1().ExecuteAndSave(Path.Combine(EnvironmentConstants.InputPath, "a_example.txt"), EnvironmentConstants.OutputPath, true);

			//Console.WriteLine($"Best score: {slideShowOutput.TotalScore}");

			Console.ReadLine();
		}
	}
}