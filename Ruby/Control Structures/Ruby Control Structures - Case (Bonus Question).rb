class Hacker
end

class Submission
end

class TestCase
end

class Contest
end
def identify_class(obj)
    # write your case control structure here
    case obj
    when Hacker, Submission, TestCase, Contest
        puts "It's a #{obj.class}!"
    else
        puts "It's an unknown model" 
    end
end

(1..gets.to_i).each do |i|
    case gets.to_s.chomp
    when "Hacker"
        identify_class(Hacker.new)
    when "Submission"
        identify_class(Submission.new)
    when "TestCase"
        identify_class(TestCase.new)
    when "Contest"
        identify_class(Contest.new)
    else
        identify_class(nil)
    end
end