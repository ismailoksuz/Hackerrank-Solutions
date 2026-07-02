$Regex_Pattern = '^[a-zA-Z]*s$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}