#!/bin/python3

import math
import os
import random
import re
import sys


def pangrams(s):
    words=[]
    for i in range(0,len(s)):
        tmp=s[i].lower()
        if tmp not in words and tmp!=' ':
            words.append(tmp)
    if(len(words)==26):
        return ("pangram")
    else:
        return ("not pangram")
    
        

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = pangrams(s)

    fptr.write(result + '\n')

    fptr.close()
