def single_quote
  # single quote string here
  'Hello World and others!'
end

def double_quote
  # Double quote string here
  "Hello World and others!"
end

def here_doc
  # Here doc string here
    <<-HERE
    Hello World and others!
    HERE
end

def __check_output
  r1, r2, r3 = single_quote, double_quote, here_doc
  flag = false
  if r1.nil? or r1.index("Hello World and others!").nil?
    puts 'Ah! Please check the output of your single quote method'
    flag = true
  end

  exit(0) if flag

  if r2.nil? or r2.index("Hello World and others!").nil?
    puts 'May be you missed just by little. Check the output for double quote method'
    flag = true
  end

  exit(0) if flag

  if r3.nil? or r3.index("Hello World and others!").nil?
    puts 'Did you check your HERE doc method thoroughly?'
    flag = true
  end

  exit(0) if flag
end

__check_output
puts 'You have successfully completed the task!'
