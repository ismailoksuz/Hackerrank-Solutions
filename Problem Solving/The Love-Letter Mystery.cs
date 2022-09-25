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


    public static int theLoveLetterMystery(string s)
    {
        int res=0;
        int cnt=0;  
        int temp=0;          
        for(var i=s.Length-1;i>(s.Length/2)-1;i--){
            temp=0;
            if(s[cnt]!=s[i]){
                temp=(int)s[cnt]-(int)s[i];
                if(temp<0)temp*=-1;
                res+=temp;
            }
            cnt+=1;
        }
        return res;
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

            int result = Result.theLoveLetterMystery(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
