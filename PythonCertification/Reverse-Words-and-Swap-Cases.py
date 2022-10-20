#!/bin/python3

import math
import os
import random
import re
import sys



#
# Complete the 'reverse_words_order_and_swap_cases' function below.
#
# The function is expected to return a STRING.
# The function accepts STRING sentence as parameter.
#

def reverse_words_order_and_swap_cases(sentence):
    seperated=[]
    start=0
    for i in range(0,len(sentence)):
        if sentence[i]==' ':
            seperated.append(sentence[start:i])
            if(i+1<len(sentence)):
                start=i+1
            else:
                break        
    seperated.append(sentence[start:len(sentence)])
    const=""
    lng=len(seperated)
    lng2=lng-1
    for j in range (0,lng):
        const+=seperated[lng2-j]
        if(j<lng2):
            const+=" "
    return const.swapcase()
        
        

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    sentence = input()

    result = reverse_words_order_and_swap_cases(sentence)

    fptr.write(result + '\n')

    fptr.close()
