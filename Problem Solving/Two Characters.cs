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
     * Complete the 'alternate' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternate(string s)
    { 
        char[] dst = s.Distinct().ToArray();
        int res = 0;
        for(int i = 0 ; i < dst.Length-1 ; i++){
            for(int j = i+1 ; j < dst.Length ; j++){
                string check = dst[i].ToString()+dst[j].ToString();
                string temp = new string(s.Where(x => check.Contains(x)).ToArray());
                if(isCons(temp) == false){
                    res = Math.Max(res, temp.Length);
                }
            }
        }
        return res;
    }
    public static bool isCons (string s){
        for(int i = 0 ; i < s.Length-1 ; i++){
            if(s[i] == s[i+1]){
                return true;
            }
        }
        return false;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = Result.alternate(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
