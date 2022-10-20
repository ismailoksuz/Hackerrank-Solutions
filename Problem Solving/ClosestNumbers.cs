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


    public static List<int> closestNumbers(List<int> arr)
    {
        arr.Sort();
        int dif=(int)Math.Abs((decimal)arr[0]-(decimal)arr[1]);     
        int temp=0;   
        List<int> res = new List<int>();
        for(var i=1;i<arr.Count-1;i++){
            temp=(int)Math.Abs((decimal)arr[i]-(decimal)arr[i+1]);
            if(temp<dif){
                res.Clear();
                res.Add(arr[i]);
                res.Add(arr[i+1]);
                dif=temp;
            }
            else if(temp==dif){
                res.Add(arr[i]);
                res.Add(arr[i+1]);
            }
        }
        return res;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.closestNumbers(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
