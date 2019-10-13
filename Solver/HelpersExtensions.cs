using System;

namespace Solver
{
	public static class HelpersExtensions
	{
		public static double ToRad(this double deg)
		{
			return Math.PI * deg / 180;
		}
	}
}