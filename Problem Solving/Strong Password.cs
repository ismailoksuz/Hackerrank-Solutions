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


    public static int minimumNumber(int n, string password)
    {
        int upper=0;
        int lower=0;
        int number=0;
        int special=0;
        int res=0;
        int result=0;
        for(var i=0;i<password.Length;i++){
            if(char.IsUpper(password[i])==true)upper+=1;
            if(char.IsLower(password[i])==true)lower+=1;
            if(char.IsNumber(password[i])==true)number+=1;
            if(char.IsLetterOrDigit(password[i])==false)special+=1;
        }
        if(upper>0)res+=1;
        if(lower>0)res+=1;
        if(number>0)res+=1;
        if(special>0)res+=1;
        int rem=4-res;
        if(rem!=0){
            if(rem+n<6)result=6-n;
            else result=rem;
        }
        else{
            if(n<6)result=6-n;
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
