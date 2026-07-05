# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = '^\([+-]?((90(\.0+)?)|((([1-8]\d{1})|\d{1})(\.\d+)?)),\s[+-]?((180(\.0+)?)|(((1[0-7]\d{1})|([1-9]\d{1})|\d{1})(\.\d+)?))\)$';
$N = <STDIN>;

for (1 .. $N) {
    print (<STDIN> =~ /$regex/ ? "Valid\n" : "Invalid\n");
}