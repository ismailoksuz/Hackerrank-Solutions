# Enter your code here. Read input from STDIN. Print output to STDOUT
$N = <STDIN>;
chomp ($N);
$text = "";

for (1 .. $N){
    $sent = <STDIN>;
    $text .= " ".$sent;
}

$T = <STDIN>;
for (1 .. $T){
    $word = <STDIN>;
    chomp ($word);
    $regex = '\b'.$word.'\b';
    $sum = 0;
    while ($text =~ /$regex/g){
        $sum++;
    }
    print $sum."\n";
}