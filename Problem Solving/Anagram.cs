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

    public static int anagram(string s)
    {
        if(s.Length % 2 == 1){
            return -1;
        }
        char[] l1 = new char[26];
        char[] l2 = new char[26];
        foreach(char c in s.Substring(0,s.Length/2)){
            l1[c - 'a']++;
        }
        foreach(char c in s.Substring(s.Length/2)){
            l2[c - 'a']++;
        }
        int res = 0;
        for(int i = 0 ; i < l1.Length ; i++){
            res += Math.Abs(l1[i]-l2[i]);
        }
        return res/2;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.anagram(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
