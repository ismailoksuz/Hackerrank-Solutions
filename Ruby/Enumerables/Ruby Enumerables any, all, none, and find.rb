def func_any(hash)
    # Check and return true if any key object within the hash is of the type Integer
    # If not found, return false.
    hash.any? {|key, value| key.is_a? Integer}
end

def func_all(hash)
    # Check and return true if all the values within the hash are Integers and are < 10
    # If not all values satisfy this, return false.
    hash.all? {|key, value| value.is_a?(Integer) && value < 10}
end

def func_none(hash)
    # Check and return true if none of the values within the hash are nil
    # If any value contains nil, return false.
    hash.none? {|key, value| value.nil?}
end

def func_find(hash)
    # Check and return the first object that satisfies either of the following properties:
    #   1. There is a [key, value] pair where the key and value are both Integers and the value is < 20 
    #   2. There is a [key, value] pair where the key and value are both Strings and the value starts with `a`.
    hash.find {|key, value| (value.is_a?(Integer) && key.is_a?(Integer) && value < 20) or (value.is_a?(String) && key.is_a?(String) && value.start_with?("a"))}
end

####1. any? check for integer key in hash (true)
h = {"a" => "a", "b" => "b", "c" => 1, 1 => 2}
ans = func_any(h)
cor = h.any? {|key, value| key.is_a? Integer}

unless ans == cor
	puts "func_any: Wrong. There is a [key, value] pair in the Hash where the key is an Integer."
else
	puts "func_any: Correct! There is a [key, value] pair in the Hash where the key is an Integer."
end

####2. any? check for integer key in hash (false)
h = {"a" => "a", "b" => "b", "c" => 1}
ans = func_any(h)
cor = h.any? {|key, value| key.is_a? Integer}

unless ans == cor
	puts "func_any: Wrong. There is no [key, value] pair in the Hash where the key is an Integer."
else
	puts "func_any: Correct! There is no [key, value] pair in the Hash where the key is an Integer."
end

####3. all? check for integer value under 10 (true)
h = {"a" => 1, "c" => 2, "d" => 3, "e" => 9}
cor = h.all? {|key, value| (value.is_a? Integer and value < 10) }
ans = func_all(h)
unless ans == cor
	puts "func_all: Wrong. All [key, value] pairs in the Hash have a value that is an Integers < 10."
else
	puts "func_all: Correct! All [key, value] pairs in the Hash have a value that is an Integer < 10."
end

####4. all? check for integer value under 10 (false)
h = {"a" => 10, "c" => 20, "d" => 30, "e" => 1}
cor = h.all? {|key, value| (value.is_a? Integer and value < 10) }
ans = func_all(h)
unless ans == cor
	puts "func_all: Wrong. Not all [key, value] pairs in the Hash have a value that's an Integer < 10."
else
	puts "func_all: Correct! Not all [key, value] pairs in the Hash have a value that's an Integer < 10."
end


####5. none? check for no nil value (true)
h = {"a" => 1, "b" => 2, "c" => 3, "d" => 1}
cor = h.none? {|key, value| value.nil?}

ans = func_none(h)

unless ans == cor
	puts "func_none: Wrong. There is no [key, value] pair in the Hash where the value is nil."
else
	puts "func_none: Correct! There is no [key, value] pair in the Hash where the value is nil."
end

####6. none? check for no nil value (true)
h = {"a" => 1, "b" => 2, "c" => 3, "d" => nil}
cor = h.none? {|key, value| value.nil?}

ans = func_none(h)

unless ans == cor
	puts "func_none: Wrong. There is a [key, value] pair in the Hash where the value is nil."
else
	puts "func_none: Correct! There is a [key, value] pair in the Hash where the value is nil."
end


####7. func_find first condition check

h = {"a" => "b", "b" => "c", 1 => 2}
cor = h.find {|key, value| (key.is_a? Integer and value.is_a? Integer and value < 20) or (key.is_a? String and value.is_a? String and value.start_with? "a")}

ans = func_find(h)
# cor = [1, 2]

unless ans == cor
	puts "func_find: Wrong. There is a [key, value] pair in the Hash that satisfies one of the properties."
else
	puts "func_find: Correct! There is a [key, value] pair in the Hash that satisfies one of the properties."
end

####7. func_find first condition check 2 (fail)

h = {2 => 40, 3 => 60, 1 => 20}
cor = h.find {|key, value| (key.is_a? Integer and value.is_a? Integer and value < 20) or (key.is_a? String and value.is_a? String and value.start_with? "a")}

ans = func_find(h)
# cor = [1, 2]

unless ans == cor
	puts "func_find: Wrong. There is no [key, value] pair in the Hash that satisfies one of the properties."
else
	puts "func_find: Correct! There is no [key, value] pair in the Hash that satisfies one of the properties."
end

####8. func_find second condition check

h = {"a" => 22, "b" => 21, "c" => "abc"}
cor = h.find {|key, value| (key.is_a? Integer and value.is_a? Integer and value < 20) or (key.is_a? String and value.is_a? String and value.start_with? "a")}

ans = func_find(h)
# cor = ["c", "abc"]

unless ans == cor
	puts "func_find: Wrong. There is a [key, value] pair in the Hash that satisfies one of the properties."
else
	puts "func_find: Correct! There is a [key, value] pair in the Hash that satisfies one of the properties."
end

####9. func_find none satisfy

h = {"a" => "b", "b" => "c", "c" => "d", 1 => "a"}
cor = h.find {|key, value| (key.is_a? Integer and value.is_a? Integer and value < 20) or (key.is_a? String and value.is_a? String and value.start_with? "a")}

ans = func_find(h)
# cor = nil

unless ans == cor
	puts "func_find: Wrong. There is no [key, value] pair in the Hash that satisfies either property."
else
	puts "func_find: Correct! There is no [key, value] pair in the Hash that satisfies either property."
end