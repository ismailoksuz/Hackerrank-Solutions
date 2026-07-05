# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = '([a-zA-Z0-9_\.]+@[a-zA-Z0-9_\.]+[a-zA-Z0-9]+)';
%mails = ();
$input = "";
$N = <STDIN>;
chomp ($N);

for (1 .. $N){
    $line = <STDIN>;
    $input .= " ".$line;
}

while ($input =~ /$regex/g){
    $mails{$1} = 1;
}

print join(";", sort keys %mails) . "\n";