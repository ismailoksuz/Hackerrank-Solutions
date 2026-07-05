# Enter your code here. Read input from STDIN. Print output to STDOUT

@sentences = ();
$n = <STDIN>;
chomp ($n);
for (1 .. $n){
    $sent = <STDIN>;
    chomp($sent);
    push @sentences, $sent;
}

$q = <STDIN>;
for (1 .. $q){
    $query = <STDIN>;
    chomp ($query);
    $reg = '\b\w+'.$query.'\w+\b';
    $sum = 0;
    for $i (0 .. $#sentences) {
        while($sentences[$i] =~ /$reg/g){
            $sum++;
        }
    }
    print $sum."\n";
}