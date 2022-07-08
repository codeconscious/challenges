global using static System.Console;
global using static Challenges.Utility;

namespace Challenges;

internal static class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            WriteLineColor("You must specify a question ID.", ConsoleColor.Red);
            return;
        }

        IRunnable runnable = args[0] switch
        {
            // Project Euler
            "euler1" => new ProjectEuler.Problem1(),
            "euler2" => new ProjectEuler.Problem2(),
            "euler3" => new ProjectEuler.Problem3(),
            "euler4" => new ProjectEuler.Problem4(),
            "euler5" => new ProjectEuler.Problem5(),
            "euler6" => new ProjectEuler.Problem6(),

            // Problems from friends
            "alphanumber" => new Friends.AlphabeticNumberPuzzleSolver(),

            // Miscellanous problems
            "longest-substring" => new Misc.LongestSubstring(),
            "palindrome" => new Misc.Anagrams(),

            // Invalid problem IDs
            _ => throw new ArgumentException("An invalid operation was passed in.")
        };

        runnable.Run();
    }
}
