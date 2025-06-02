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
    public static List<int> acmTeam(List<string> topic)
    {
        List <int> li = new List<int>();
        for(int i = 0 ; i < topic.Count() - 1 ; i++){
            for(int j = i+1 ; j < topic.Count() ; j++){
                li.Add(getOnes(topic.ElementAt(i),topic.ElementAt(j)));
            }
        }
        li.Sort();
        li.Reverse();
        int cnt = 0;
        for(int i = 0 ; i < li.Count() ; i++){
            if(li.ElementAt(i) == li.ElementAt(0)){
                cnt += 1;
            }
            else{
                break;
            }
        }
        return new List<int> {li.Max(),cnt};
    }
    public static int getOnes (string s1, string s2){
        int ones = 0;
        for(int i = 0 ; i < s1.Length ; i++){
            ones += (s1[i] == '1' || s2[i] == '1') ? 1 : 0;
        }
        return ones;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<string> topic = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string topicItem = Console.ReadLine();
            topic.Add(topicItem);
        }

        List<int> result = Result.acmTeam(topic);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
