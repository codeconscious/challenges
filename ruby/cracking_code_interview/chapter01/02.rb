# Problem 2: Are two strings permutations of each other?
# frozen_string_literal: true

# Displays the text and results on the terminal.
def print_results(first, second)
  print "  - #{first.nil? ? 'NIL' : first}, #{second.nil? ? 'NIL' : second} -> "
  puts are_strings_permutations?(first, second).to_s.upcase
end

# Returns a bool indicating if two given strings are permutations of each other.
def are_strings_permutations?(first, second)
  return true if first == second
  return true if first.nil? && second.nil?
  return false if first.nil? || second.nil?
  return false if first.length != second.length

  char_counts(first) == char_counts(second)
end

# Returns a hash containing the counts for each character in the given text.
def char_counts(text)
  text.chars.to_a.each_with_object({}) do |char, hash|
    hash[char] = hash.key?(char) ? hash[char] + 1 : 1
  end
end

# Test cases
print_results(nil, nil); # TRUE
print_results('aabaa', 'baaaa'); # TRUE
print_results('012345', '543210'); # TRUE
print_results('!@#$%', '%$#@!'); # TRUE
print_results('あいうえお', 'おえういあ'); # TRUE
print_results('aba', nil); # false
print_results(nil, 'aba'); # false
print_results('aabaa', 'caaaa'); # false
print_results('012345', '54321A'); # false
print_results('012345', '543210A'); # false
