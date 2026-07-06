# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = qr/(\/\/.*|\/\*[\s\S]*?\*\/)/;
$code = "";

while (<STDIN>){
    $code .= $_;
}

while ($code =~ /$regex/g) {
    $out = $1;
    $out =~ s/^[ \t]+//gm;
    print $out."\n";
}