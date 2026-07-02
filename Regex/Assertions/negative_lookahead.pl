$Regex_Pattern = '(.)(?!\1)';

$Test_String = <STDIN> ;
$count = () = $Test_String =~ /$Regex_Pattern/g;
print "Number of matches : ",$count ;