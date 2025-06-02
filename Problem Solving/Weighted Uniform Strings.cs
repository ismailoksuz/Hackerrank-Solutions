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
    public static List<string> weightedUniformStrings(string s, List<int> queries)
    {
        List<string> res = new List<string>();
        List<char> strLi = new List<char>();
        List<int> intLi = new List<int>();
        for(int i = 0 ; i < s.Length; i++){
            strLi.Add(s[i]);
            int rep = 1;
            int j = i+1;
            while(j < s.Length && s[i] == s[j]){
                rep += 1;
                j += 1;
                i += 1;
            }
            intLi.Add(rep);
        }
        List<int> vals = new List<int>();
        for (int i = 0 ; i < strLi.Count() ; i++){
            for(int j = 1 ; j <= intLi.ElementAt(i) ; j++){
                vals.Add(j*(Convert.ToInt32(strLi.ElementAt(i))-96));
            }
        }
        foreach(int i in queries){
            res.Add(vals.Contains(i) ? "Yes" : "No");
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> queries = new List<int>();

        for (int i = 0; i < queriesCount; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<string> result = Result.weightedUniformStrings(s, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
