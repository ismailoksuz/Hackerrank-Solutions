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
    public static int squares(int a, int b)
    {;
        int firstsquare=0;
        int lastsquare=0;
        int i=a;
        int j=b;
        int res=0;
        while(i<=b){
            if((double)(int)Math.Sqrt(i)==Math.Sqrt(i)){
                firstsquare=(int)Math.Sqrt(i);
                break;
            }
            i+=1;
        }
        while(j>=a){
            if((double)(int)Math.Sqrt(j)==Math.Sqrt(j)){
                lastsquare=(int)Math.Sqrt(j);
                break;
            }
            j-=1;
        }
        for(var k=firstsquare;k<lastsquare;k++){
            res+=1;
        }
        if(firstsquare==lastsquare){
            if(firstsquare!=0)return 1;
            else return 0;
        }
        else return res+1;
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
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(firstMultipleInput[0]);

            int b = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.squares(a, b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
