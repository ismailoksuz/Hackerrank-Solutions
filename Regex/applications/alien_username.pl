# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = '^(_|\.)[0-9]+[a-zA-Z]*_?$';
$n = <STDIN>;

for(1 .. $n){
    $pass = <STDIN>;
    if($pass =~ /$regex/){
        print "VALID\n";
    } else {
        print "INVALID\n";
    }
}