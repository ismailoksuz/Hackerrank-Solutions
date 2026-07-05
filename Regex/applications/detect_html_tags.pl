# Enter your code here. Read input from STDIN. Print output to STDOUT
$reg = '<(\s)?(\w+)(\s)?([^<>]*)?>';
%tags = ();

while ($inp = <STDIN>) {
    while ($inp =~ /$reg/g) {
        $tags{$2} = 1;
    }
}
print join(";", sort keys %tags);