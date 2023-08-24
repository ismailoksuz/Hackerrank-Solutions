#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'strangeCounter' function below.
#
# The function is expected to return a LONG_INTEGER.
# The function accepts LONG_INTEGER t as parameter.
#

def strangeCounter(t):
    total = getSum(t)
    return (total-t)

def getSum(t):
    cycle = getCycle(t)
    res = 4
    if(cycle == 1):
        return res;   
    i = 1
    while(i < cycle):
        res += 3*int((math.pow(2,i))) 
        i += 1
    return res

def getCycle(t):
    i = 0
    while(t > 0):
        t -= 3*int((math.pow(2,i)))
        i += 1
    return i  

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    t = int(input().strip())

    result = strangeCounter(t)

    fptr.write(str(result) + '\n')

    fptr.close()

