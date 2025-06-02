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
    public static int makingAnagrams(string s1, string s2)
    {
        char[] fl1 = new char[26];
        char[] fl2 = new char[26];
        foreach(char c in s1){
            fl1[c - 'a'] ++;
        }
        foreach(char c in s2){
            fl2[c - 'a'] ++;
        }
        int res = 0;
        for(int i = 0 ; i < fl1.Length ; i++){
            res += Math.Abs(fl1[i]-fl2[i]);
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = Result.makingAnagrams(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
