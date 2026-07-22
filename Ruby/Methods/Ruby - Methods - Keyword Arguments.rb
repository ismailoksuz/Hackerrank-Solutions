# Your code here
def convert_temp(temp, input_scale:, output_scale: 'celsius')
    return temp if input_scale == output_scale
    celsius = input_scale == 'celsius' ? temp : (input_scale == 'fahrenheit' ? (temp - 32) / 1.8 : temp - 273.15)
    output_scale == 'celsius' ? celsius : (output_scale == 'kelvin' ? celsius + 273.15 : celsius * 1.8 + 32)
end


unless Object.respond_to?(:convert_temp, true)
  puts 'You must define the correct method!'
  exit(0)
end

o1 = convert_temp(0, input_scale: 'kelvin', output_scale: 'celsius')
o2 = convert_temp(393, input_scale: 'kelvin', output_scale: 'celsius')
o3 = convert_temp(400, input_scale: 'fahrenheit', output_scale: 'celsius')
o4 = convert_temp(333, input_scale: 'fahrenheit', output_scale: 'kelvin')

a1, a2, a3, a4 = -273.15, 119.85, 204.4444, 440.372

unless [o1 - a1, o2 - a2, o3 - a3, o4 - a4].all? { |x| x.abs < 0.001 }
  puts 'Something went wrong! Please check your answers!'
  exit(0)
end

puts 'You have succesfully completed the challenge!'
