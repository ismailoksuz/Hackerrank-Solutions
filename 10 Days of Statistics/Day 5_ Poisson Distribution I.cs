using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        double mean = Convert.ToDouble(Console.ReadLine());
        int val = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(poisson(mean,val).ToString("F3"));
    }
    static double poisson (double n, int x){
        double num = Math.Pow(n,x)*Math.Pow(Math.E,-n);
        long denom = factorial(x);
        return num/denom;
    }
    static long factorial (int k){
        long fac = 1;
        while(k > 1){
            fac *= k;
            k -= 1;
        }
        return fac;
    }
}
