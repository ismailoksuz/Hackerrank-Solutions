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
     * Complete the 'interQuartile' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY values
     *  2. INTEGER_ARRAY freqs
     */

    public static void interQuartile(List<int> values, List<int> freqs)
    {
        List<int> arr = OneList(values,freqs);
        arr.Sort();
        List<int> output = new List<int>();
        int ul = arr.Count/2-1;
        List<int> lowMed = new List<int>();
        List<int> upMed = new List<int>();
        int i = 0;
        while(i <= ul){
            lowMed.Add(arr[i]);
            i += 1;
        }
        if(arr.Count % 2 == 1){
            i += 1;
        }
        while(i < arr.Count){
            upMed.Add(arr[i]);
            i += 1;
        }
        double gm = getMed(lowMed);
        double um = getMed(upMed);
        double diff = um - gm;
        Console.WriteLine(diff.ToString("F1"));

    }
    public static List<int> OneList (List<int> values, List<int> freqs){
        List<int> combined = new List<int>();
        int f;
        for(int i = 0 ; i < values.Count ; i++){
            f = 0;
            while(f < freqs[i]){
                combined.Add(values[i]);
                f += 1;
            }
        }
        return combined;
    }
    public static double getMed (List<int> arr){
        int um = ((arr.Count)/2);
        if(arr.Count%2 == 1){
            return ((double)arr[um]);
        }
        else{
            return ((double)((arr[um]+arr[um-1])/2));
        }
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> val = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(valTemp => Convert.ToInt32(valTemp)).ToList();

        List<int> freq = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(freqTemp => Convert.ToInt32(freqTemp)).ToList();

        Result.interQuartile(val, freq);
    }
}
