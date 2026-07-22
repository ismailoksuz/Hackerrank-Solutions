combination = -> (n) do
    -> (r) do
        ((1..n).inject(:*) / ((1..r).inject(:*) * (1..(n-r)).inject(:*)))
    end
end

n = gets.to_i
r = gets.to_i
nCr = combination.(n)
puts nCr.(r)