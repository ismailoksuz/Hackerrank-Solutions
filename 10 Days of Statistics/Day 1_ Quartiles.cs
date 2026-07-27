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
     * Complete the 'quartiles' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> quartiles(List<int> arr)
    {
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
        output.Add(getMed(lowMed));
        output.Add(getMed(arr));
        output.Add(getMed(upMed));
        return output;
       
    }
    
    public static int getMed (List<int> arr){
        int um = ((arr.Count)/2);
        if(arr.Count%2 == 1){
            return arr[um];
        }
        else{
            return ((arr[um]+arr[um-1])/2);
        }
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> data = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(dataTemp => Convert.ToInt32(dataTemp)).ToList();

        List<int> res = Result.quartiles(data);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
