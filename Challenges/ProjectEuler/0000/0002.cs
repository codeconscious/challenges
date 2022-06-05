namespace Challenges.ProjectEuler;

/// <summary>
/// Goal: By considering the terms in the Fibonacci sequence whose values
/// do not exceed four million, find the sum of the even-valued terms.
/// (https://projecteuler.net/problem=2)
/// </summary>
public class Problem2 : IRunnable
{
    public void Run()
    {
        var relevantNumbers = Fibonacci(4_000_000)
            .Where(n => n % 2 == 0)
            .Sum();

        Utility.WriteLineColor(
            relevantNumbers.ToString(),
            ConsoleColor.Green);
    }

    public static IEnumerable<int> Fibonacci(int max)
    {
        var prev = -1;
        var next = 1;

        while (true)
        {
            var sum = prev + next;

            if (sum > max)
                yield break;

            prev = next;
            next = sum;

            yield return sum;
        }
    }
}