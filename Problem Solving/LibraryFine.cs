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


    public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        int y=(y1-y2)*10000;
        int m=(m1-m2)*500;
        int d=(d1-d2)*15;
        if(y>0)return Math.Abs((int)((decimal)y));
        else if(y==0 && m>0)return Math.Abs((int)((decimal)m));
        else if(y==0 && m==0 && d>0)return Math.Abs((int)((decimal)d));
        else return 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d1 = Convert.ToInt32(firstMultipleInput[0]);

        int m1 = Convert.ToInt32(firstMultipleInput[1]);

        int y1 = Convert.ToInt32(firstMultipleInput[2]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d2 = Convert.ToInt32(secondMultipleInput[0]);

        int m2 = Convert.ToInt32(secondMultipleInput[1]);

        int y2 = Convert.ToInt32(secondMultipleInput[2]);

        int result = Result.libraryFine(d1, m1, y1, d2, m2, y2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
