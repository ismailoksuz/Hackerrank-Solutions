#!/bin/python3

import math
import os
import random
import re
import sys


def libraryFine(d1, m1, y1, d2, m2, y2):
    y=(y1-y2)*10000
    m=(m1-m2)*500
    d=(d1-d2)*15
    if(y>0):
        return abs(y)
    elif(y==0 and m>0):
        return abs(m)
    elif(y==0 and m==0 and d>0):
        return abs(d)
    else:
        return 0
        

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    first_multiple_input = input().rstrip().split()

    d1 = int(first_multiple_input[0])

    m1 = int(first_multiple_input[1])

    y1 = int(first_multiple_input[2])

    second_multiple_input = input().rstrip().split()

    d2 = int(second_multiple_input[0])

    m2 = int(second_multiple_input[1])

    y2 = int(second_multiple_input[2])

    result = libraryFine(d1, m1, y1, d2, m2, y2)

    fptr.write(str(result) + '\n')

    fptr.close()
