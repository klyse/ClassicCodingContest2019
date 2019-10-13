namespace Solver.Algorithms {
	public interface ISolver<out TOutput, in TInput>
	{
		TOutput Solve(TInput input);
	}
}