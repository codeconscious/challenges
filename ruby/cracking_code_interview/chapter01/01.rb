# Problem 1: Are all string characters unique?

# Displays the text and results on the terminal.
def print_results(text)
  print "   #{text} -> "
  puts all_chars_unique?(text)
end

# Returns a bool indicating whether all characters in a string are unique.
def all_chars_unique?(text)
  chars = text.split('')
  used_chars = []

  chars.each do |letter|
    return false if used_chars.include?(letter)

    used_chars.push(letter)
  end

  true
end

print_results('abcdefghijklmnopqrstuvwxyz')
print_results('aabcdefghijklmnopqrstuvwxyz')
print_results('abcdefghijklmnopqrstuvwxyza')
