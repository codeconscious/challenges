namespace Challenges.Misc;

public class LongestSubstring : IRunnable
{
    public void Run()
    {
        var strings = new List<string?>
        {
            null,
            "",
            "aaa",
            "aaabbbbbbacc",
            "aaabbbbbbacccccccc",
            "aaaaaaaaaaaaaaaaaaaaaaaaaabbbbbbbbaaadddddddddddddeeeeeeeee"
        };

        strings.ForEach(s => WriteLine(GetLongestPart(s)));
    }

    private static string GetLongestPart(string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        var indexLengthMap = new Dictionary<int, int>();
        var workingIndex = 0;

        for (var testIndex = 0; testIndex < text.Length; testIndex++)
        {
            // If we have a new letter
            if (testIndex == 0 || text[testIndex] != text[testIndex-1])
            {
                indexLengthMap.Add(testIndex, 1);
                workingIndex = testIndex;
            }
            else
            {
                indexLengthMap[workingIndex]++;
            }
        }

        var longestPair = indexLengthMap.MaxBy(m => m.Value);

        var startIndex = longestPair.Key;
        var endIndex = startIndex + longestPair.Value;

        return text[startIndex..endIndex];
    }
}
