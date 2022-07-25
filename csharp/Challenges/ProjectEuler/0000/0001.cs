namespace Challenges.ProjectEuler;

/// <summary>
/// If we list all the natural numbers below 10 that are multiples of 3 or 5,
/// we get 3, 5, 6 and 9. The sum of these multiples is 23.
/// Find the sum of all the multiples of 3 or 5 below 1000.
/// (https://projecteuler.net/problem=1)
/// </summary>
public class Problem1 : IRunnable
{
    public void Run()
    {
        const int upperLimit = 1000;

        // LINQ is clearly not best performance-wise,
        // but its functional-style legibility is great.
        var multiplesOf3And5 = Enumerable
            .Range(0, upperLimit)
            .Where(n => n % 3 == 0 || n % 5 == 0)
            .Sum(n => n);

        WriteLine(multiplesOf3And5);
    }
}