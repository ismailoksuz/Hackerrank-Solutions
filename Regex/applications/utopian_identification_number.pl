# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = '^[a-z]{0,3}[0-9]{2,8}[A-Z]{3,}$';
$N = <STDIN>;

for(1 .. $N){
    $inp = <STDIN>;
    if($inp =~ /$regex/){
        print "VALID\n";
    }
    else{
        print "INVALID\n";
    }
}