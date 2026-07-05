# Enter your code here. Read input from STDIN. Print output to STDOUT
$reg1 = '^hackerrank';
$reg2 = 'hackerrank$';

$N = <STDIN>;

for(1 .. $N){
    $sentence = <STDIN>;
    if($sentence =~ /$reg1/){
        if($sentence =~ /$reg2/){
            print "0\n"
        }
        else{
            print "1\n";
        }
    }
    elsif($sentence =~ /$reg2/){
        print "2\n";
    }
    else{
        print "-1\n";
    }
}