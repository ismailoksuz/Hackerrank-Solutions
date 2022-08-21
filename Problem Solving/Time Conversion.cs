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
    public static string timeConversion(string s)
    {
        string last2=s.Substring(8,2);
        string without=s.Substring(0,8);        
        int hh=Int32.Parse(s.Substring(0,2));
        string mm=s.Substring(3,2);
        string ss=s.Substring(6,2);
        if(last2=="AM"){
            if(hh==12){
                return("00:"+mm+":"+ss);
            }
            else{
                return without;
            }
        }
        else{
            if(hh==12){
                return without;
            }
            else{
                return((hh+12).ToString()+":"+mm+":"+ss);
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
