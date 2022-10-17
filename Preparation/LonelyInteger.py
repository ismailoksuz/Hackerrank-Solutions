#!/bin/python3

import math
import os
import random
import re
import sys


def lonelyinteger(a):
    if(len(a)<3):
        return a[0]        
    a.sort()
    for i in range(0,len(a)-1):
        if(i%2==0 and a[i]!=a[i+1]):
            return a[i]
    return a[len(a)-1]
        
    
        

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    a = list(map(int, input().rstrip().split()))

    result = lonelyinteger(a)

    fptr.write(str(result) + '\n')

    fptr.close()