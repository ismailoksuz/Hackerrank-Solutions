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
    
    public static int diagonalDifference(List<List<int>> arr)
    {
        var n=arr[0].Count;
        int s1=0;
        int s2=0;
        for(int i=0;i<n;i++){
            s1+=arr[i][i];
        }
        for(int j=n-1;j>=0;j--){
            s2+=arr[j][n-1-j];
        }
        int res=s1-s2;
        if(res<0){
            res=res*-1;
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

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
