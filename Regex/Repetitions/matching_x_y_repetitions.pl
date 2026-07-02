$Regex_Pattern = '^\d{1,2}[a-zA-Z]{3,}\.{0,3}$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}