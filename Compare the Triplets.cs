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
    public static Listint compareTriplets(Listint a, Listint b)
    {
        int ares=0;
        int bres=0;
        Listint temp = new Listint(); 
        for(var i=0;ia.Count;i++){
            if(a[i]b[i])ares+=1;
            if(a[i]b[i])bres+=1;
        }
       temp.Add(ares);
       temp.Add(bres);
       return temp;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable(OUTPUT_PATH), true);

        Listint a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp = Convert.ToInt32(aTemp)).ToList();

        Listint b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp = Convert.ToInt32(bTemp)).ToList();

        Listint result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join( , result));

        textWriter.Flush();
        textWriter.Close();
    }
}
