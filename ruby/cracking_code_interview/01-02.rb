# Returns a bool indicating if two given strings are
# permutations of each other.
def problem_2_are_strings_permutations(first, second)
    if (first == nil && second == nil)
        return true
    elsif (first == nil || second == nil)
        return false
    elsif (first.length() != second.length())
        return false
    end

    frequencyHash = {}

    # Increase map values for each character instance in the first string,
    # and decrease for each in the second string.
    for i in 0..first.length()-1
        if frequencyHash.key?(first[i])
            frequencyHash[first[i]] += 1
        elsif
            frequencyHash[first[i]] = 1
        end

        if frequencyHash.key?(second[i])
            frequencyHash[second[i]] -= 1
        elsif
            frequencyHash[second[i]] = -1
        end
    end

    # All map pair values equaling 0 means the character frequencies are
    # identical, indicating that the strings are permutations of each other.
    frequencyHash.each do |key, value|
        if value != 0
            return false
        end
    end

    return true
end

# Test cases
puts problem_2_are_strings_permutations("aabaa", "baaaa"); # true
puts problem_2_are_strings_permutations("aabaa", "caaaa"); # false
puts problem_2_are_strings_permutations("012345", "543210"); # true
puts problem_2_are_strings_permutations("012345", "54321A"); # false
puts problem_2_are_strings_permutations("012345", "543210A"); # false
