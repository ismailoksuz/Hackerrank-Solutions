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
    public static long repeatedString(string s, long n)
    {
        long res=0;
        if(s.Length==1){
            if(s[0]=='a')res=n;
            else res=0;
        }
        else{
            if(n>s.Length){
                for(var i=0;i<s.Length;i++){
                    if(s[i]=='a')res+=1;
                }
                res*=(n/s.Length);
                for(var j=0;j<(n%s.Length);j++){
                    if(s[j]=='a')res+=1;
                }
            }
            else if(n==s.Length){
                for(var k=0;k<s.Length;k++){
                    if(s[k]=='a')res+=1;
                }
            }        
            else{
                for(var l=0;l<n;l++){
                    if(s[l]=='a')res+=1;
                }
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

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
