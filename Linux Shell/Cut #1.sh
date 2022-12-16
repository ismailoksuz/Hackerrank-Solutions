while read inp 
do 
    echo $(echo $inp | cut -c 3)
done
