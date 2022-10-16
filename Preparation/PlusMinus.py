#!/bin/python3

import math
import os
import random
import re
import sys


def plusMinus(arr):
    pos=neg=zero=0
    for i in arr:
        if(i>0):
            pos+=1
        elif(i<0):
            neg+=1
        else:
            zero+=1
    sum=pos+neg+zero
    print(float(pos)/float(sum))
    print(float(neg)/float(sum))
    print(float(zero)/float(sum))
        

if __name__ == '__main__':
    n = int(input().strip())

    arr = list(map(int, input().rstrip().split()))

    plusMinus(arr)
