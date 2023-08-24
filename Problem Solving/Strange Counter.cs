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

    /*
     * Complete the 'strangeCounter' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER t as parameter.
     */

    public static long strangeCounter(long t)
    {
        return(getSum(t) - t);
    }
    
    public static long getSum (long t){
        long cycle = getCycle(t);
        long sum = 4;
        if(cycle == 1){
            return sum;
        }
        for(int i = 1 ; i < cycle ; i++){
            sum += 3*getExp(i);
        }
        return sum;
        
    }
    
    public static long getCycle (long t){
        int i = 0;
        while(t > 0){
            t -= 3*getExp(i);
            i += 1;
        }
        return i;
    }
    public static long getExp (long e){
        long res = 1;
        for(int i = 0 ; i < e ; i++){
            res*=2;
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        long t = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.strangeCounter(t);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

