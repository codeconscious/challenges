# Determines whether a string is comprised of unique characters,
# returning a bool indicating the result.
def problem_1_has_unique_chars(text)
    chars = text.split('')
    used_chars = []

    chars.each do |letter|
        if used_chars.include? letter
            return false;
        else
            used_chars.push(letter)
        end
    end

    return true;
end

puts problem_1_has_unique_chars("abcdefghijklmnopqrstuvwxyz")
puts problem_1_has_unique_chars("aabcdefghijklmnopqrstuvwxyz")
