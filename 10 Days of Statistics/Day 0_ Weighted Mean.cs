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

    public static void weightedMean(List<int> X, List<int> W)
    {
        int sum = 0;
        int sumW = 0;
        for(int i = 0 ; i < X.Count ; i++){
            sum += X[i]*W[i];
            sumW += W[i];
        }
        Console.Write(String.Format("{0:F1}", ((double)sum)/((double)sumW)));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> vals = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valsTemp => Convert.ToInt32(valsTemp)).ToList();

        List<int> weights = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(weightsTemp => Convert.ToInt32(weightsTemp)).ToList();

        Result.weightedMean(vals, weights);
    }
}
