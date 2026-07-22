# Enter your code here. Read input from STDIN. Print output to STDOUT

require 'prime'

n = gets.to_i
p 1.upto(Float::INFINITY).lazy.select { |x| x.prime? && x.to_s == x.to_s.reverse }.first(n)