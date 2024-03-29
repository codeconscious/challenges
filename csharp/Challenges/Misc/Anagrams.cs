namespace Challenges.Misc;

public class Anagrams : IRunnable
{
    public void Run()
    {
        WriteLine(AreStringsAnagramsOfEachOther("aaab", "baaa"));
        WriteLine(AreStringsAnagramsOfEachOther("aaab", "baaaa")); // Unequal
        WriteLine(AreStringsAnagramsOfEachOther("こんにちは！", "！はちにこん"));
        WriteLine(AreStringsAnagramsOfEachOther("こんにちは！", "はちにこん")); // Unequal
    }

    private static bool AreStringsAnagramsOfEachOther(string text1, string text2)
    {
        if (string.IsNullOrWhiteSpace(text1) && string.IsNullOrWhiteSpace(text2))
            return true;

        if (string.IsNullOrWhiteSpace(text1) || string.IsNullOrWhiteSpace(text2))
            return false;

        if (text1 == text2)
            return true;

        var charFrequency1 = GetCharFrequencies(text1);
        var charFrequency2 = GetCharFrequencies(text2);

        return AreDictionariesEqual(charFrequency1, charFrequency2);

        static Dictionary<char, int> GetCharFrequencies(string text)
        {
            var charFrequencies = new Dictionary<char, int>();

            for (var i = 0; i < text.Length; i++)
            {
                if (charFrequencies.ContainsKey(text[i]))
                    charFrequencies[text[i]]++;
                else
                    charFrequencies.Add(text[i], 1);
            }

            return charFrequencies;
        }

        // A less manual solution could use .OrderBy(kvp => kvp.Key).SequenceEqual
        // (cf. https://stackoverflow.com/a/9547410/11767771).
        static bool AreDictionariesEqual(Dictionary<char, int> first, Dictionary<char, int> second)
        {
            if (first.Count != second.Count)
                return false;

            foreach (var firstPair in first)
            {
                if (!second.ContainsKey(firstPair.Key))
                    return false;

                if (firstPair.Value != second[firstPair.Key])
                    return false;
            }

            return true;
        }
    }
}
