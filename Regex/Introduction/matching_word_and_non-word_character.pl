$Regex_Pattern = '\w\w\w\W\w\w\w\w\w\w\w\w\w\w\W\w\w\w';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}