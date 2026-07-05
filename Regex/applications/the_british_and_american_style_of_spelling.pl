# Enter your code here. Read input from STDIN. Print output to STDOUT
$us = '\w+ze(\s\w+)?';
$uk = '\w+se(\s\w+)?';
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
    $word = <STDIN>;
    chomp ($word);
    if ($word =~ /$us/){
        $other = substr($word, 0, -2)."se";
    }
    elsif ($word =~ /$uk/){
        $other = substr($word, 0, -2)."ze";
    }
    $sum = 0;
    for $i (0 .. $#words) {
        if ($words[$i] eq $word or $words[$i] eq $other){
            $sum++;
        }
    }
    print $sum."\n";
}