$Regex_Pattern = '^[a-z][1-9][^a-z][^A-Z][A-Z]';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}