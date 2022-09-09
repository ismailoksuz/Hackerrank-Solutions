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


    public static string hackerrankInString(string s)
    {
        int res=0;
        List<char> st = new List<char>();
        st.Add('h');
        st.Add('a');
        st.Add('c');
        st.Add('k');
        st.Add('e');
        st.Add('r');
        st.Add('r');
        st.Add('a');
        st.Add('n');
        st.Add('k');
        for(var i=0;i<s.Length;i++){
            if(s[i]==st[0]){
                st.RemoveAt(0);
                res+=1;
            }
            if(res==10){
                break;
            }
        }
        if(res==10)return "YES";
        else return "NO";
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

            string result = Result.hackerrankInString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
