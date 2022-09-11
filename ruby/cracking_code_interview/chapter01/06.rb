# Problem 6: Compress a string. Example: "aaabbbbbb" -> "a3b6".
#            Returns the original string no shortening is done.
#            Assume only Englishletters.
# frozen_string_literal: true

def print_results(text)
  puts "  - #{text} -> #{compress_text(text)}"
end

def compress_text(text)
  output = ''
  current_char = text[0]
  current_total = 0

  text.chars.each do |ch|
    if ch == current_char
      current_total += 1
    else
      output += "#{current_char}#{current_total}"
      current_char = ch
      current_total = 1
    end
  end
  output += "#{current_char}#{current_total}"
  output
end

print_results('aaabbb')
print_results('aaaaabbbbbbcddeeeaaa')
