namespace Challenges.ProjectEuler;

/// <summary>
/// Goal: Find the difference between the sum of the squares of
/// the first 100 natural numbers and the square of the sum.
/// (https://projecteuler.net/problem=6)
/// </summary>
public class Problem6 : IRunnable
{
    public void Run()
    {
        var numbers = Enumerable.Range(1, 100).ToList();

        var sumOfSquares = (from n in numbers select n * n).Sum();
        var squareOfSum = (int) Math.Pow(numbers.Sum(), 2);
        var difference = squareOfSum - sumOfSquares;

        Utility.WriteLineColor(difference.ToString(), ConsoleColor.Green);
    }
}