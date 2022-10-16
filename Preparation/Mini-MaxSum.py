#!/bin/python3

import math
import os
import random
import re
import sys


def miniMaxSum(arr):
    res=0    
    for i in arr:
        res+=i
    print(res-max(arr),res-min(arr))

if __name__ == '__main__':

    arr = list(map(int, input().rstrip().split()))

    miniMaxSum(arr)

