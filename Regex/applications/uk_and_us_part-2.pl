# Enter your code here. Read input from STDIN. Print output to STDOUT
@words = ();
$N = <STDIN>;
chomp ($N);
for (1 .. $N){
    $inp = <STDIN>;
    chomp ($inp);    
    push @words, split(/\s+/, $inp);
}

$T = <STDIN>;
for (1 .. $T){
    $W = <STDIN>;
    chomp ($W);
    ($us = $W) =~ s/our/or/g;
    $sum = 0;
    for $i (0 .. $#words) {
        if ($words[$i] eq $W or $words[$i] eq $us){
            $sum++;
        }
    }
    print $sum."\n";
}