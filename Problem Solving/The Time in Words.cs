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
    public static string hoursword(int h){
        List<string> hours = new List<string>();
        hours.Add("one");
        hours.Add("two");
        hours.Add("three");
        hours.Add("four");
        hours.Add("five");
        hours.Add("six");
        hours.Add("seven");
        hours.Add("eight");
        hours.Add("nine");
        hours.Add("ten");
        hours.Add("eleven");
        hours.Add("twelve");
        return hours[h-1];        
    }
    public static string minword(int m){
        List<string> mins = new List<string>();
        mins.Add("one");
        mins.Add("two");
        mins.Add("three");
        mins.Add("four");
        mins.Add("five");
        mins.Add("six");
        mins.Add("seven");
        mins.Add("eight");
        mins.Add("nine");
        mins.Add("ten");
        mins.Add("eleven");
        mins.Add("twelve");
        mins.Add("thirteen");
        mins.Add("fourteen");
        mins.Add("quarter");
        mins.Add("sixteen");
        mins.Add("seventeen");
        mins.Add("eighteen");
        mins.Add("nineteen");
        mins.Add("twenty");
        mins.Add("twenty one");
        mins.Add("twenty two");
        mins.Add("twenty three");
        mins.Add("twenty four");
        mins.Add("twenty five");
        mins.Add("twenty six");
        mins.Add("twenty seven");
        mins.Add("twenty eight");
        mins.Add("twenty nine");
        mins.Add("half");
        return mins[m-1];        
    }
    public static string timeInWords(int h, int m)
    {    
        if(m==0)return (hoursword(h)+" o' clock");
        else if(m==1)return ("one minute past "+hoursword(h));      
        else if(m<=30){
            if(m%15==0)return (minword(m)+" past "+hoursword(h));
            else return (minword(m)+" minutes past "+hoursword(h));
        }
        else{
            if(m%15==0)return (minword(60-m)+" to "+hoursword(h+1));
            else return (minword(60-m)+" minutes to "+hoursword(h+1));
        }
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine().Trim());

        int m = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.timeInWords(h, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
