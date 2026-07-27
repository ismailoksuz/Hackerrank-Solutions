using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        List<int> math = new List<int>();
        List<int> stat = new List<int>();
        double multSum = 0;
        double mathSqSum = 0;
        for(int i = 0 ; i < 5 ; i++){
            string[] input = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(input[0]);
            int s = Convert.ToInt32(input[1]);
            math.Add(m);
            stat.Add(s);
            multSum += m*s;
            mathSqSum += Math.Pow(m,2);
        }
        double mathSum = math.Sum();
        double statSum = stat.Sum();
        double b = (5*multSum - mathSum*statSum)/(5*mathSqSum-Math.Pow(mathSum,2));
        double a = calculateMean(stat) - b * calculateMean(math);
        Console.WriteLine((a + b * 80).ToString("F3"));
    }
    static double calculateMean (List<int> list){
        double sum = 0;
        foreach(double val in list){
            sum += val;
        }
        return sum/list.Count;
    }
}
