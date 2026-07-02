$Regex_Pattern = '^\d+[A-Z]+[a-z]+$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}