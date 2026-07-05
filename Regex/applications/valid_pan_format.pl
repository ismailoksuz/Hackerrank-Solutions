# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = '^[A-Z]{5}\d{4}[A-Z]$';
$N = <STDIN>;

for (1 .. $N){
    $PAN = <STDIN>;
    if ($PAN =~ /$regex/){
        print "YES\n";
    }
    else{
        print "NO\n";
    }
}