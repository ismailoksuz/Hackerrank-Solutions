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

    public static string pangrams(string s)
    {
        s=s.ToLower();
        List<char> words = new List<char>();
        char tmp;
        for(var i=0;i<s.Length;i++){
            tmp=s[i];
            if(words.Contains(tmp)==false && tmp!=' ')words.Add(tmp);
        }
        if(words.Count==26)return("pangram");
        else return("not pangram");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
