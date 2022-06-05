namespace Challenges.ProjectEuler;

/// <summary>
/// What is the largest prime factor of the number 600851475143?
/// (https://projecteuler.net/problem=3)
/// </summary>
public class Problem3 : IRunnable
{
    public void Run()
    {
        const long target = 13195; //600_851_475_143;
        var primeSearchCeiling = (long) Math.Floor((double) (target / 2));

        // var primeNumbers = Enumerable.Range(1, (int)Math.Floor((double) (target / 2))).Where(IsPrime);
        var primeNumbers = GetPrimeNumbers(1, primeSearchCeiling);

        // WriteLine(string.Join("; ", primeNumbers));

        WriteLineColor(
            primeNumbers.Last().ToString(),
            ConsoleColor.Green);
    }

    private static IEnumerable<long> GetPrimeNumbers(long start = 1, long max = long.MaxValue)
    {
        for (var i = start; i < max; i++)
        {
            if (IsPrime(i))
                yield return i;
        }
    }

    private static bool IsPrime(long number)
    {
        return number > 1 && CalculatePrime(number);

        bool CalculatePrime(long value)
        {
            var possibleFactors = Math.Sqrt(number);

            for (var factor = 2; factor <= possibleFactors; factor++)
                if (value % factor == 0)
                    return false;
            
            return true;
        }
    }
}