#!/bin/python3

import math
import os
import random
import re
import sys


def closestNumbers(arr):
    arr.sort()
    dif=10**14
    res=[]
    for i in range(0,len(arr)-1):
        temp=abs(arr[i]-arr[i+1])
        if (temp<dif):
            res.clear()
            res.append(arr[i])
            res.append(arr[i+1])
            dif=temp
        elif(temp==dif):
            res.append(arr[i])
            res.append(arr[i+1])
    return res
            

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    arr = list(map(int, input().rstrip().split()))

    result = closestNumbers(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
