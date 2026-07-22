# Initialize 3 variables here as explained in the problem statement
array = []
array_1 = [nil]
array_2 = [10, 10]


unless defined? array
    puts "variable named array is not defined"
    exit 0
else
    puts "variable named array is defined!"
end

unless array.is_a? Array
    puts "array must belong to the class `Array`"
    exit 0
else
    puts "array variable belongs to the class `Array`!"
end

unless 0 == array.size
    puts "array must be of size 0"
    exit 0
else
    puts "array variable is of size 0!"
end

unless defined? array_1
    puts "variable named array_1 is not defined"
    exit 0
else
    puts "variable named array_1 is defined!"
end

unless array_1.is_a? Array
    puts "array_1 must belong to the class `Array`"
    exit 0
else
    puts "array_1 variable belongs to the class `Array`!"
end

unless 1 == array_1.size
    puts "array_1 must be of size 1"
    exit 0
else
    puts "array_1 variable is of size 1!"
end

unless array_1[0].nil?
    puts "Element of the array_1 is not nil"
    exit 0
else
    puts "Element of the array_1 is nil!"
end

unless defined? array_2
    puts "variable named array_2 is not defined"
    exit 0
else
    puts "variable named array_2 is defined!"
end

unless array_2.is_a? Array
    puts "array_2 must belong to the class `Array`"
    exit 0
else
    puts "array_1 variable belongs to the class `Array`!"
end

unless 2 == array_2.size
    puts "array_2 must be of size 2"
    exit 0
else
    puts "array_2 variable is of size 2!"
end

unless (10 == array_2[0] and  10 == array_2[1])
    puts "Each element of array_2 must be of value 10"
    exit 0
else
    puts "Each element of array_2 is 10!"
end