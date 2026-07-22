class Colors
  include Enumerable

  def each
    yield "Red"
    yield "Green"
    yield "Blue"
  end
end

colors = Colors.new

def iterate_colors(colors)
  # Your code here
  colors.to_a
end


returned_colors = iterate_colors(colors)

if not returned_colors.is_a? Array
  puts "You must return an Array."
  exit(0)
end

if returned_colors.nil?
  puts "Your returned array doesn't not contain any color."
  exit(0)
end

if returned_colors.length != 3 and (not returned_colors.nil?)
  puts 'Your array must iterate over all the values.'
  exit(0)
end

if returned_colors != ["Red", "Green", "Blue"]
  puts 'You must return correct colors in correct order.'
  exit(0)
end

puts 'Correct! You have succesfully iterated over the elements.'
