$Regex_Pattern = '\b[aeiouAEIOU][a-zA-Z]*\b';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}