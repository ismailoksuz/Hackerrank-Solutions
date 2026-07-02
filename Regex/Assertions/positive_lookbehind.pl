$Regex_Pattern = '(?<=[13579])\d';

$Test_String = <STDIN> ;
$count = () = $Test_String =~ /$Regex_Pattern/g;
print "Number of matches : ",$count ;