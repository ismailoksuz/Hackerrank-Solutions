#!/bin/python3

import math
import os
import random
import re
import sys


 
def kaprekarNumbers(p, q):
    result=[]
    for i in range (p,q+1):
        lng=len(str(i))
        exp=10**lng
        sqr=i*i
        left=sqr//exp
        right=sqr%exp
        if left+right==i:
            result.append(i)
    if len(result)==0:
        print("INVALID RANGE")
    else:
        print(*result)
    
        
    

if __name__ == '__main__':
    p = int(input().strip())

    q = int(input().strip())

    kaprekarNumbers(p, q)
