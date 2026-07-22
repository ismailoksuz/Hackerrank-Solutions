# Your code here
def serial_average(str)
    sss = str[0, 3]
    num1 = str[4, 5].to_f
    num2 = str[10, 5].to_f
    avg = ((num1 + num2) / 2.0).round(2)
    "#{sss}-#{avg}"
end

def __check_output
  unless Object.respond_to?(:serial_average, true)
    puts 'You must define appropriate method.'
    exit(0)
  end

  s1 = ["001-12.43-56.78", "789-01.09-78.89", "642-67.58-83.16"]
  a1 = ["001-34.61", "789-39.99", "642-75.37"]

  ans = s1.map { |x| serial_average(x) }

  unless ans == a1
    puts 'Oops! There seems to be some mistake. Recheck please?'
    puts "You can check your output on example case '#{s1.first}'."
    exit(0)
  end
end

__check_output
puts 'You can successfully move to the next challenge!'
