# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = '^(\d+)(\s|-)(\d+)\2(\d+)$';
$N = <STDIN>;

for(1 .. $N){
    $inp = <STDIN>;
    if($inp =~ /$regex/){
        print "CountryCode=$1,LocalAreaCode=$3,Number=$4\n";
    }
}