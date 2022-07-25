# Problem 1: Are all string characters unique?

# Displays the text and results on the terminal.
def print_results(text)
    print %Q["#{text}" -> ]
    puts has_unique_chars(text)
end

# Returns a bool indicating whether all string characters are unique.
def has_unique_chars(text)
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

print_results("abcdefghijklmnopqrstuvwxyz")
print_results("aabcdefghijklmnopqrstuvwxyz")
print_results("abcdefghijklmnopqrstuvwxyza")
