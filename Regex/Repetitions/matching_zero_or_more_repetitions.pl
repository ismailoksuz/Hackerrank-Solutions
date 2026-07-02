$Regex_Pattern = '^\d{2,}[a-z]*[A-Z]*$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}