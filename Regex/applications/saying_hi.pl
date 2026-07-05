# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = '^(h|H)(i|I)\s[^dD]';
$n = <STDIN>;

for(1 .. $n){
    $s = <STDIN>;
    if($s =~ /$regex/){
        print $s; 
    }
}