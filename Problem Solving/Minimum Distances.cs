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


    public static int minimumDistances(List<int> a)
    {
        int dis=a.Count;
        for(var i=0;i<a.Count;i++){            
            int temp=dis;
            for(var j=i+1;j<a.Count;j++){
                if(a[i]==a[j]){
                    temp=i-j;                    
                }
                if(temp<0)temp*=-1;
                if(temp<dis)dis=temp;
            }
        }
        if(dis==a.Count)dis=-1;
        return dis;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
