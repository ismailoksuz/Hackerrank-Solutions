using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] input = Console.ReadLine().Split(' ');
        double aMean = Convert.ToDouble(input[0]);
        double bMean = Convert.ToDouble(input[1]);
        double aCost = 160 + 40*(aMean+Math.Pow(aMean,2));
        double bCost = 128 + 40*(bMean+Math.Pow(bMean,2));
        Console.WriteLine(aCost.ToString("F3"));
        Console.WriteLine(bCost.ToString("F3"));
    }
}
