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

    public static int reverse (int i){
        int rev = 0;
        int rem;
        while (i != 0) {
            rem = i % 10;
            rev = rev * 10 + rem;
            i /= 10;
        }
        return rev;
    }
    public static int beautifulDays(int i, int j, int k)
    {
        int res=0;
        int rev;        
        for(var tmp=i;tmp<=j;tmp++){
            rev=reverse(tmp);     
            if((tmp-rev)%k==0)res+=1;
        }
        return res;        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = Result.beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
