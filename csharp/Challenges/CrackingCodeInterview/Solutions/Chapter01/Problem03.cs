using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Console;

namespace Challenges.CrackingCodingInterview;

public class Problem03_ReplaceStrings : IRunnable
{
    public void Run()
    {
        PrintResults("Mr John Smith      ", 13);
    }

    private static void PrintResults(string text, int actualLength)
    {
        WriteLine($"\"{text}\" -> \"{Check(text, actualLength)}\"");

        static string Check(string text, int actualLength)
        {
            var sb = new StringBuilder(actualLength);
            for (var i = 0; i < actualLength; i++)
            {
                sb.Append(text[i] == ' ' ? "%20" : text[i]);
            }

            return sb.ToString();
        }
    }
}
