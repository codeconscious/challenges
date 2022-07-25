using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Challenges.CrackingCodingInterview;

public class Problem01_AreAllCharsUnique : IRunnable
{
    public void Run()
    {
        WriteLine(Check("abcde"));
        WriteLine(Check("abcdea"));
    }

    private static bool Check(string text)
    {
        // LINQ version
        // return text.Length == text.Distinct().Count();

        var usedChars = new HashSet<char>(text.Length);

        for (var i = 0; i < text.Length; i++)
        {
            if (usedChars.Contains(text[i]))
                return false;
            else
                usedChars.Add(text[i]);
        }

        return true;
    }
}
