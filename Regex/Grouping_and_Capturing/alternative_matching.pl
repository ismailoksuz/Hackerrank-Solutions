$Regex_Pattern = '^(Mr\.|Mrs\.|Ms\.|Dr\.|Er\.)[a-zA-Z]+$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}