#!/bin/python3

import math
import os
import random
import re
import sys


def timeConversion(s):
    hour=int(s[0:2])
    if(s[8:10]=='PM'):        
        if(hour<12):
            hour+=12
        return (str(hour)+s[2:8])
    else:
        if(hour==12):
            return ('00'+s[2:8])
        else:
            return (s[0:8])
        
        

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = timeConversion(s)

    fptr.write(result + '\n')

    fptr.close()
