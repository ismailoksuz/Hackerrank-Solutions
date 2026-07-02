$Regex_Pattern = '^[a-zA-Z02468]{40}[13579\s]{5}$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}