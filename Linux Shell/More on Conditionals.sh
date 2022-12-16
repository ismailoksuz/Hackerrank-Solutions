read k1
read k2
read k3
if [ $k1 -eq $k2 ]&&[ $k2 -eq $k3 ]
then
    echo EQUILATERAL
elif [ $k1 -eq $k2 ]||[ $k2 -eq $k3 ]||[ $k1 -eq $k3 ]
then
    echo ISOSCELES    
else
    echo SCALENE
fi
