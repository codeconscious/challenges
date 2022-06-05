namespace Challenges.ProjectEuler;

/// <summary>
/// Goal: The smallest positive number that is evenly divisible by all of the numbers from 1 to 20.
/// (https://projecteuler.net/problem=1)
/// </summary>
public class Problem5 : IRunnable
{
    public void Run()
    {
        var currentNumber = 20;
        var testDivisors = Enumerable.Range(1, 20).ToList();
        int remainder = 0; // Only needed for method 2 below.

        do
        {
            // Method 1, using the remainder operator:
            // if (testDivisors.All(d => currentNumber % d == 0))
            //     break;

            // Method 2, using Math.DivRem:
            if (testDivisors.All(d =>
            {
                Math.DivRem(currentNumber, d, out remainder);
                return remainder == 0;
            }))
            {
                break;
            }

            currentNumber++;

        } while (currentNumber < int.MaxValue);

        WriteLine(currentNumber);
    }
}