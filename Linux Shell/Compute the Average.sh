#!/bin/bash
read N
declare -i cnt=$N
declare -i res=0
while [ $cnt -gt 0 ]
do
   read temp
   res=$((res + temp))
   cnt=$((cnt - 1))
done
printf "%.3f\n" `echo "$res/$N" | bc -l`

