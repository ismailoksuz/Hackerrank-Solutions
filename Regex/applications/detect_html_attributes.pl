# Enter your code here. Read input from STDIN. Print output to STDOUT
$N = <STDIN>;
chomp ($N);
$html = "";

for (1 .. $N){
    $html .= <STDIN>;
}

%tags = ();
$tagreg = '<([a-z0-9]+)[^>]*>';
$atrreg = '([a-z]+)=(("[^"]*")|(\'[^\']*\')|([^\s>]+))';

while ($html =~ /$tagreg/g){
    $tag = $1;
    $full_tag = $&;
    $tags{$tag} //= {};
    while ($full_tag =~ /$atrreg/g) {
        $attr = $1;
        $tags{$tag}{$attr} = 1;
    }
}

foreach $t (sort keys %tags) {
    @attrs = sort keys %{$tags{$t}};
    print "$t:" . join(",", @attrs) . "\n";
}