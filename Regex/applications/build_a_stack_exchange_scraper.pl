# Enter your code here. Read input from STDIN. Print output to STDOUT
$reg1 = 'id="question-summary-(\d*)"';
$reg2 = 'class="question-hyperlink">(.*)</a>';
$reg3 = 'class="relativetime">(.*)</span>';

while (my $inp = <STDIN>) {
    if ($inp =~ /$reg1/) {
        $id = $1;
    }
    if ($inp =~ /$reg2/) {
        $about = $1;
    }
    if ($inp =~ /$reg3/) {
        $time = $1;
        print "$id;$about;$time\n";
    }
}