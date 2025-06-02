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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int lcm = a.Aggregate(getLCM);
        int gcd = b.Aggregate(getGCD);
        int count = 0;
        for (int i = lcm; i <= gcd; i += lcm){
            if (gcd % i == 0){
                count++;
            }
        }
        return count;
    }
    public static int getLCM(int n1, int n2){
        return (n1 * n2)/getGCD(n1,n2);
    }
    public static int getGCD(int n1, int n2){
        var r1 = findSeqs(getRoots(n1));
        var r2 = findSeqs(getRoots(n2));
        int gcd = 1;
        int i = 0;
        while(i < r1.Count){
            int j = 0;
            while(j < r2.Count){
                if(r1[i].Item1 == r2[j].Item1){
                    gcd *= (int)Math.Pow((r1[i].Item1), (Math.Min(r1[i].Item2, r2[j].Item2)));
                    break;
                }
                j += 1;
            }
            i += 1;
        }
        return gcd;
    }
    public static List<(int,int)> findSeqs (List<int> roots){
        var sequences = roots
            .GroupBy(x => x)
            .Select(g => (g.Key, g.Count()))
            .ToList();
        return sequences;
    }
    public static List<int> getRoots (int n){
        List<int> roots = new List<int>();
        int div = 2;
        while(n >= div){
            while(n % div == 0){
                n /= div;
                roots.Add(div);
            }
            div += 1;
        }
        return roots;
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

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
