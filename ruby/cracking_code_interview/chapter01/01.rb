# Problem 1: Are all string characters unique?
# frozen_string_literal: true

# Displays the text and results on the terminal.
def print_results(text)
  print "   #{text} -> "
  puts all_chars_unique?(text)
end

# Returns a bool indicating whether all characters in a string are unique.
def all_chars_unique?(text)
  text.chars.to_a.length == text.chars.to_a.uniq.length
end

print_results('abcdefghijklmnopqrstuvwxyz')
print_results('aabcdefghijklmnopqrstuvwxyz')
print_results('abcdefghijklmnopqrstuvwxyza')
