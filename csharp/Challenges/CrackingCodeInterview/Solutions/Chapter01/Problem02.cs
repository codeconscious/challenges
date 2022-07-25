using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Challenges.CrackingCodingInterview;

public class Problem02_AreStringsPermutations : IRunnable
{
    public void Run()
    {
        WriteLine(Check("aabaa", "baaaa")); // true
        WriteLine(Check("aabaa", "caaaa")); // false
        WriteLine(Check("012345", "543210")); // true
        WriteLine(Check("012345", "54321A")); // false
        WriteLine(Check("012345", "543210A")); // false
    }

    private static bool Check(string first, string second)
    {
        if (first is null && second is null)
            return true;

        if (first is null || second is null)
            return false;

        if (first.Length != second.Length)
            return false;

        // LINQ version (Not particularly efficient)
        // return string.Concat(first.OrderBy(ch => ch))
        //              .SequenceEqual(string.Concat(second.OrderBy(ch => ch)));

        var frequencyMap = new Dictionary<char, int>();

        // Increase map values for each character instance in the first string,
        // and decrease for each in the second string.
        for (var i = 0; i < first.Length; i++)
        {
            if (frequencyMap.ContainsKey(first[i]))
                frequencyMap[first[i]]++;
            else
                frequencyMap.Add(first[i], 1);

            if (frequencyMap.ContainsKey(second[i]))
                frequencyMap[second[i]]--;
            else
                frequencyMap.Add(second[i], -1);
        }

        // All map pair values equaling 0 means the character frequencies are
        // identical, indicating that the strings are permutations of each other.
        foreach (var mapPair in frequencyMap)
        {
            if (mapPair.Value != 0)
                return false;
        }

        return true;
    }
}
