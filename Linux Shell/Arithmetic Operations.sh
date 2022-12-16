read input
echo $input | bc -l | xargs printf "%.3f"
