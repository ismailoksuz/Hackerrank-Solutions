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

    public static long marcsCakewalk(List<int> calorie)
    {
        long res=0;
        double exp=0;
        while(calorie.Count>0){
            res+=(long)((double)calorie.Max()*Math.Pow((double)2, exp));
            calorie.Remove(calorie.Max());
            exp+=(double)1;
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> calorie = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(calorieTemp => Convert.ToInt32(calorieTemp)).ToList();

        long result = Result.marcsCakewalk(calorie);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
