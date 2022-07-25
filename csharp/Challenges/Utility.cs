using System;

namespace Challenges;

public static class Utility
{
    public static void WriteLineColor(string text, ConsoleColor color)
    {
        ArgumentNullException.ThrowIfNull(text);
        ArgumentNullException.ThrowIfNull(color);

        ForegroundColor = color;
        WriteLine(text);
        ResetColor();
    }
}
