# Enter your code here. Read input from STDIN. Print output to STDOUT
$v4 = '(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])';
$v6 = '[0-9a-fA-F]{1,4}';
$ipv4 = '^'.$v4.'\.'.$v4.'\.'.$v4.'\.'.$v4.'$';
$ipv6 = '^'.$v6.':'.$v6.':'.$v6.':'.$v6.':'.$v6.':'.$v6.':'.$v6.':'.$v6.'$';

$N = <STDIN>;
for (1 .. $N){
    $ip = <STDIN>;
    if($ip =~ /$ipv4/){
        print "IPv4\n";
    }
    elsif($ip =~ /$ipv6/){
        print "IPv6\n";
    }
    else{
        print "Neither\n";
    }
}