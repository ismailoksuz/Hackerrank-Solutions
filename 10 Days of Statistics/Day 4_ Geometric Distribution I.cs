using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] input = Console.ReadLine().Split(' ');
        double p = (Convert.ToDouble(input[0])/Convert.ToDouble(input[1]));
        int n = Convert.ToInt32(Console.ReadLine());
        double gd = geometricDist(n,p);
        Console.WriteLine(gd.ToString("F3"));
        
    }
    static double geometricDist (double n, double p){
        return (Math.Pow(1-p,n-1)*p);
    }
}