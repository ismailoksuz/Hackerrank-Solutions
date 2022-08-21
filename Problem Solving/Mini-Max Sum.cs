using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    
    public static void miniMaxSum(List<int> arr)
    {
        long max=arr.Max();
        long min=arr.Min();
        long res1=0;
        long res2=0;
        long sum=0;
        foreach (var item in arr){
            sum+=item;
        }
        res1=sum-max;
        res2=sum-min;
        Console.Write(res1+" "+res2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
