namespace Challenges.ProjectEuler;

/// <summary>
/// Find the largest palindrome made from the product of two 3-digit numbers.
/// (https://projecteuler.net/problem=4)
/// </summary>
public class Problem4 : IRunnable
{
    public void Run()
    {
        var threeDigitNumbers = Enumerable.Range(100, 900);

        var products = (from n1 in threeDigitNumbers
                        from n2 in threeDigitNumbers
                        select n1 * n2).Distinct();

        var largestPalindrome = products
            .Where(n => n.ToString() == string.Concat(n.ToString().Reverse()))
            .Max();

        WriteLine(largestPalindrome);
    }
}