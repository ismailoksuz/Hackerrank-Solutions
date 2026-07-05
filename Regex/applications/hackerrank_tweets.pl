# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = 'hackerrank';
$sum = 0;

$n = <STDIN>;
for(1 .. $n){
    $tweet = <STDIN>;
    if($tweet =~ /$regex/i){
        $sum++
    }
}

print $sum;