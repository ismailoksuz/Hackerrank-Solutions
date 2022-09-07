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


    public static List<int> cutTheSticks(List<int> arr)
    {
        List<int> sticks = new List<int>();
        while(arr.Count>0){
            int min=arr.Min();
            sticks.Add(arr.Count);
            for(var i=0;i<arr.Count;i++){
                if(arr[i]>=min){
                    arr[i]-=min;                    
                }
                if(arr[i]==0){
                    arr.RemoveAt(i);
                    i-=1;
                }                
            }
        }
        return sticks;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.cutTheSticks(arr);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
