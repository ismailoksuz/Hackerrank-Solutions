def group_by_marks(marks, pass_marks)
  # your code here
  marks.group_by { |name, mark| mark >= pass_marks ? "Passed" : "Failed" }
end

def _group_by_marks(marks, n)
  marks.group_by do |key, value|
    if value < n
      'Failed'
    else
      'Passed'
    end
  end
end

marks = {"Ramesh" => 23, "Vivek" => 40, "Harsh" => 88, "Mohammad" => 60}

n = gets.to_i
t1 = group_by_marks(marks, n)
a1 = _group_by_marks(marks, n)

unless t1.is_a? Hash
  puts 'Watch out! Your method must return a Hash.'
end

unless t1 == a1
  puts 'Ooops! Seems like you missed something in output.'
  exit(0)
end

puts 'Cool! You have completed the group_by challenge!'
