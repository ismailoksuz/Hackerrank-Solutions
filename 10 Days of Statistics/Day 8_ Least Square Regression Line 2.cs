using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        double multSum = 0, mathSqSum = 0, mathSum = 0, statSum = 0;
        for(int i = 0 ; i < 5 ; i++){
            string[] input = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(input[0]);
            int s = Convert.ToInt32(input[1]);
            mathSum += m;
            statSum += s;
            multSum += m*s;
            mathSqSum += Math.Pow(m,2);
        }
        double mathMean = (double)mathSum / 5;
        double statMean = (double)statSum / 5;
        double b = (5*multSum - mathSum*statSum)/(5*mathSqSum-Math.Pow(mathSum,2));
        double a = statMean - b * mathMean;
        Console.WriteLine((a + b * 80).ToString("F3"));
    }
}
