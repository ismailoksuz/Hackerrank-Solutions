$Regex_Pattern = '^\d\w\w\w\w\.$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}