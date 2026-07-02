$Regex_Pattern = '^([a-z]\w\s\W\d\D[A-Z][a-zA-Z][aeiouAEIOU]\S)\1$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}