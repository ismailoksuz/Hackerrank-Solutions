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

    /*
     * Complete the 'stdDev' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void stdDev(List<int> arr)
    {
        double sum = 0;
        double mean = getMean(arr);
        foreach(double item in arr){
            sum += (item-mean)*(item-mean);
        }
        string res = Math.Sqrt(sum / arr.Count).ToString("F1");
        Console.WriteLine(res);
    }

    public static double getMean (List<int> arr){
        int sum = 0;
        foreach(int item in arr){
            sum += item;
        }
        return ((double)(sum/arr.Count));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> vals = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();

        Result.stdDev(vals);
    }
}
