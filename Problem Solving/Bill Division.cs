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
    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int anna=0;
        int sum=0;
        for(var i=0;i<bill.Count;i++){
            if(i!=k)anna+=bill[i];
            sum+=bill[i];
        }
        int res=anna/2;
        if(b==res){
            Console.WriteLine("Bon Appetit");
        }
        else{
            Console.WriteLine(sum/2-res);
        }
        
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        Result.bonAppetit(bill, k, b);
    }
}
