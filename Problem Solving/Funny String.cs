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

    public static string funnyString(string s)
    {
        List<int> normal = new List<int>();
        List<int> rev = new List<int>();
        int lng=s.Length;
        int dif=0;
        for(var i=0;i<s.Length-1;i++){
            dif=((int)s[i])-((int)s[i+1]);
            if(dif<0)dif*=-1;
            normal.Add(dif);
        }
        for(var j=s.Length-1;j>0;j--){
            dif=((int)s[j])-((int)s[j-1]);
            if(dif<0)dif*=-1;
            rev.Add(dif);
        }
        int res=0;
        for(var k=0;k<normal.Count;k++){
            if(normal[k]==rev[k])res+=1;
        }
        if(res!=normal.Count)return "Not Funny";
        else return "Funny";

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

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
