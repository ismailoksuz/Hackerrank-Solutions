# Enter your code here. Read input from STDIN. Print output to STDOUT
$java = 'import\sjava';
$c = '#include<stdio.h>';
$code = "";

while (<STDIN>){
    $code .= $_;
}

print $code =~ /$java/ ? "Java" : $code =~ /$c/ ? "C" : "Python";