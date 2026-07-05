# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = 'http(s)?://(ww[w2]\.)?([a-zA-Z0-9-\.]+\.[a-z]+)';
%links = ();
$input = "";
$N = <STDIN>;
chomp ($N);

for (1 .. $N){
    $line = <STDIN>;
    $input .= " ".$line;
}

while ($input =~ /$regex/g){
    $links{$3} = 1;
}

print join(";", sort keys %links) . "\n";