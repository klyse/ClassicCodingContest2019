using System;
using System.IO;
using System.Collections.Generic;

namespace Solver
{
	public static class HelpersExtensions
	{
		public static double ToRad(this double deg)
		{
			return Math.PI * deg / 180;
		}

		public static string[] Read(this string fileName)
		{
			var readAllLines = File.ReadAllLines(Path.Combine(EnvironmentConstants.DataPath, EnvironmentConstants.InputPath, fileName));
			return readAllLines;
		}

		public static void Write(this string fileName, string[] lines)
		{
			File.WriteAllLines(Path.Combine(EnvironmentConstants.DataPath, EnvironmentConstants.OutputPath, fileName), lines);
		}
        public static void Write(this string fileName, string line)
        {
            Write(fileName, new List<string> { line }.ToArray());
        }
    }
}