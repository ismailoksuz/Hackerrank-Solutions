#!/bin/python3

import math
import os
import random
import re
import sys


#
# Complete the 'missingCharacters' function below.
#
# The function is expected to return a STRING.
# The function accepts STRING s as parameter.
#

def missingCharacters(s):
    numbers=[]
    words=[]
    for i in range(0,len(s)):
        if(ord(s[i])<=122 and ord(s[i])>=96):
            if s[i] not in words:
                words.append(ord(s[i]))
        elif(ord(s[i])<=57 and ord(s[i])>=47):
            if s[i] not in numbers:
                numbers.append(ord(s[i]))
    numbers.sort()
    words.sort()
    missing=[]
    for k in range(47,58):
        if k not in numbers:
            missing.append(k)
    for m in range(97,123):
        if m not in words:
            missing.append(m)
    result=""
    for t in range(1,len(missing)):
        result+=chr(missing[t])
    return result
            
        
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = missingCharacters(s)

    fptr.write(result + '\n')

    fptr.close()
