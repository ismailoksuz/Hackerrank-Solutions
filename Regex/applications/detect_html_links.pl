# Enter your code here. Read input from STDIN. Print output to STDOUT
$N = <STDIN>;
chomp ($N);
$regex = '<a\shref="([^"]+)"[^>]*?>(.*?)</a>';
$html = "";

for (1 .. $N){
    $link = <STDIN>;
    chomp ($link);
    $html .= $link;
}

while ($html =~ /$regex/g){
    $link = $1;
    $title = $2;
    $title =~ s/<[^>]*>//g;
    $link =~ s/^\s+|\s+$//g;
    $title =~ s/^\s+|\s+$//g;
    print "$link,$title\n";
} 