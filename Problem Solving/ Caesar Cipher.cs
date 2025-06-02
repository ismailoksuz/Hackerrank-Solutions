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

    public static string caesarCipher(string s, int k)
    {
        string res = "";
        for(int i = 0 ; i < s.Length ; i++){
            string type = getType(Convert.ToChar(s[i]));
            res += getType(Convert.ToChar(s[i])) == "symbol" ? Convert.ToChar(s[i]) : (getType(Convert.ToChar(s[i])) == "lower" ? changeLower(s[i],k) : changeUpper(s[i],k));
        }
        return res;
    }
    public static char changeUpper(char c, int k){
        int init = Convert.ToInt32(Convert.ToChar(c)) - 65;
        init = (init+k)%26;
        return Convert.ToChar(init+65);
    }
    public static char changeLower(char c, int k){
        int init = Convert.ToInt32(Convert.ToChar(c)) - 97;
        init = (init+k)%26;
        return Convert.ToChar(init+97);
    }
    
    public static string getType (char c){
        int val = Convert.ToInt32(Convert.ToChar(c));
        if(val >= 65 && val <= 90){
            return "upper";
        }
        else if(val >=97 && val <= 122){
            return "lower";
        }
        else{
            return "symbol";
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
