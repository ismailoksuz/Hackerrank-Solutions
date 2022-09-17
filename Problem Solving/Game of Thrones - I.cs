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

    public static string gameOfThrones(string s)
    {
        string res="NO";
        List<char> temp = new List<char>();
        for(var i=0;i<s.Length;i++){
            if(temp.Contains(s[i])==false)temp.Add(s[i]);
        }
        List<int> temp2 = new List<int>();
        for(var j=0;j<temp.Count;j++){
            temp2.Add(0);
        }
        for(var k=0;k<s.Length;k++){
            for(var m=0;m<temp2.Count;m++){
                if(s[k]==temp[m])temp2[m]+=1;
            }            
        }
        int odd=0;
        int even=0;
        foreach (int item in temp2){
            if(item%2!=0)odd+=1;
            else even+=1;
        }
        if(s.Length%2==0){
            if(odd==0)res="YES";
        }        
        else{
            if(odd==1)res="YES";
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
