def select_arr(arr)
  # select and return all odd numbers from the Array variable `arr`
  arr.select {|a| a%2 == 1}
end

def reject_arr(arr)
  # reject all elements which are divisible by 3
  arr.reject {|a| a%3 == 0}
end

def delete_arr(arr)
  # delete all negative elements
  arr.delete_if {|a| a < 0}
end

def keep_arr(arr)
  # keep all non negative elements ( >= 0)
  arr.keep_if {|a| a >= 0}
end


arr = [3, 4, 2, 1, 2, 3, 4, 5, 6]

odd_elements = select_arr(arr)

unless odd_elements == arr.select {|a| a % 2 == 1}
    val = "nil" if val.nil?
    puts "You have to return only odd valued elements from the array."
    exit(0)
else
    puts "Correct! You have returned odd valued elements from the array!"
end

reject_div_3 = reject_arr(arr)

unless reject_div_3 == arr.reject {|a| a % 3 == 0}
    val = "nil" if val.nil?
    puts "You have to return all numbers that are not divisible by 3"
    exit(0)
else
    puts "Correct! You have returned all numbers that are divisible by 3!"
end

delete_neg = delete_arr(arr)

unless delete_neg == arr.delete_if {|a| a < 0}
    val = "nil" if val.nil?
    puts "You have to delete all the negative elements of the array"
    exit(0)
else
    puts "Correct! You have deleted all the negative elements of the array!"
end

keep_pos = keep_arr(arr)

unless keep_pos == arr.keep_if {|a| a > 0}
    val = "nil" if val.nil?
    puts "You have to retain all the positive elements of the array"
    exit(0)
else
    puts "Correct! You have retained all the positive elements of the array!"
end