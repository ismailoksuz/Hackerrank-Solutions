$Regex_Pattern = '(^(tac)+$)|(^(tac){2,}(tac|tictac)*(tic)?$)';

$Test_String = <STDIN> ;
if($Test_String =~ /$Regex_Pattern/){
    print "true";
} else {
    print "false";
}