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

    public static int equalizeArray(List<int> arr)
    {
        int res=0;
        int maxindex=0;
        int tmp=arr.Count;
        for(var i=0;i<arr.Count;i++){
            int temp=0;
            for(var j=i+1;j<arr.Count;j++){
                if(arr[i]==arr[j])temp+=1;
            }
            if (temp>res){
                res=temp;
                maxindex=arr[i];
            }
        }
        for(var k=0;k<arr.Count;k++){
            if(arr[k]!=maxindex){
                arr.RemoveAt(k);
                k-=1;
            }
        }
        if(res==0)return tmp-1;
        else return tmp-arr.Count();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
