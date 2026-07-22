# Your code here
def count_multibyte_char(str)
    count = 0
    str.each_char do |char|
        count += 1 if char.bytesize > 1
    end
    count
end


def __check_output
  unless Object.respond_to?(:count_multibyte_char, true)
    puts 'You must define the appropriate method!'
    exit(0)
  end

  str_1 = 'δεν κατέγραψα στη βρίσκεται πνεύματος.'
  str_2 = 'Lorem ipsum ανάγνωσή 復讐者 factum videor'
  str_3 = 'Лей упованье english яви воспеваю Для'

  ans = [str_1, str_2, str_3].map { |x| count_multibyte_char(x) }

  # magic numbers!
  unless ans == [33, 11, 25]
    puts 'Are you sure counting the characters with more than 1 byte size?'
    puts 'The numbers seem to be off! Please recheck'
    exit(0)
  end
end

__check_output
puts 'Voila! You can now move on to next challenge!'
