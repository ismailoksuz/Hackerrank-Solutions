# Enter your code here. Read input from STDIN. Print output to STDOUT
$regex = '^[1-9][0-9]{4}\s(C|CPP|JAVA|PYTHON|PERL|PHP|RUBY|CSHARP|HASKELL|CLOJURE|BASH|SCALA|ERLANG|CLISP|LUA|BRAINFUCK|JAVASCRIPT|GO|D|OCAML|R|PASCAL|SBCL|DART|GROOVY|OBJECTIVEC)$';
$N = <STDIN>;

for (1 .. $N){
    $inp = <STDIN>;
    if($inp =~ /$regex/){
        print "VALID\n";
    }
    else{
        print "INVALID\n";
    }
}