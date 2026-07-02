$Regex_Pattern = '^\D[^aeiou][^bcDF][^\r\n\t\f\s][^AEIOU][^.,]$';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}