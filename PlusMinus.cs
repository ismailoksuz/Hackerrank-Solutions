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

    public static void plusMinus(List<int> arr)
    {
        double p=0;
        double n=0;
        double z=0;
        foreach (var item in arr){
            if (item>0)p+=1;
            if (item==0)z+=1;
            if (item<0)n+=1;
        }
        double sum=p+n+z;
        Console.WriteLine(p/sum);
        Console.WriteLine(n/sum);
        Console.WriteLine(z/sum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
