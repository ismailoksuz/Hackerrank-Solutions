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


    public static void staircase(int n)
    {
        int hash = 1;
        int space = n-1;
        int tmp=0;
        while(tmp<n){
            for(int i=0;i<space;i++){
                Console.Write(" ");
            }
            for(int j=0;j<hash;j++){
                Console.Write("#");
            }
            tmp+=1;
            space-=1;
            hash+=1;
            Console.WriteLine();
        }
        
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
