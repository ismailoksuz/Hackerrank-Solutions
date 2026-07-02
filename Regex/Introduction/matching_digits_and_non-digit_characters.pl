$Regex_Pattern = '\d\d\D\d\d\D\d\d\d\d';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}