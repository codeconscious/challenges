namespace Challenges.Misc;

public class Palindrome : IRunnable
{
    public void Run()
    {
        WriteLine(AreStringsPalindromesOfEachOther("aaab", "baaa"));
        WriteLine(AreStringsPalindromesOfEachOther("aaab", "baaaa")); // Unequal
        WriteLine(AreStringsPalindromesOfEachOther("こんにちは！", "！はちにこん"));
        WriteLine(AreStringsPalindromesOfEachOther("こんにちは！", "はちにこん")); // Unequal
    }

    private static bool AreStringsPalindromesOfEachOther(string text1, string text2)
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

        static bool AreDictionariesEqual(Dictionary<char, int> first, Dictionary<char, int> second)
        {
            if (first.Count != second.Count)
                return false;

            foreach (var pair in first)
            {
                if (!second.ContainsKey(pair.Key))
                    return false;

                if (pair.Value != second[pair.Key])
                    return false;
            }

            return true;
        }
    }
}
