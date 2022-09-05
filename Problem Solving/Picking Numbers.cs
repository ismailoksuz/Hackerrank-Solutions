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


    public static int pickingNumbers(List<int> a)
    {
        int res=0;
        for(var i=0;i<a.Count;i++){
            int temp=0;
            int temp2=0;
            int temp3=0;
            for(var j=i+1;j<a.Count;j++){
                if(a[i]-a[j]==1)temp+=1;
                if(a[j]-a[i]==1)temp2+=1;
                if(a[i]==a[j])temp3+=1;
            }
            temp+=temp3;
            temp2+=temp3;
            if(temp>temp2){
                if(temp>res)res=temp;
            }
            else{
                if(temp2>res)res=temp2;
            }
        }
        return res+1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
