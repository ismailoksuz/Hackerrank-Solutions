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
    public static int migratoryBirds(List<int> arr)
    {
        
        List<int> nums = new List<int>(); 
        int no1=0;
        int no2=0;
        int no3=0;
        int no4=0;
        int no5=0;  
        int k=0;      
        for(var i=0;i<arr.Count;i++){
            if(arr[i]==1)no1+=1;
            if(arr[i]==2)no2+=1;
            if(arr[i]==3)no3+=1;
            if(arr[i]==4)no4+=1;
            if(arr[i]==5)no5+=1;
        }
        nums.Add(no1);
        nums.Add(no2);
        nums.Add(no3);
        nums.Add(no4);
        nums.Add(no5);
        for(var j=0;j<5;j++){
            if(nums[j]==nums.Max()){
                k=j+1;
                break;
            }
        }
        return k;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
