using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int sampleSize = Convert.ToInt32(Console.ReadLine());
        double mean = Convert.ToDouble(Console.ReadLine());
        double sDev = Convert.ToDouble(Console.ReadLine());
        double dp = Convert.ToDouble(Console.ReadLine());
        double z = Convert.ToDouble(Console.ReadLine());
        double stnErr = sDev / Math.Sqrt(sampleSize);
        double mrgErr = z * stnErr;
        Console.WriteLine((mean-mrgErr).ToString("F2"));
        Console.WriteLine((mean+mrgErr).ToString("F2"));
    }
}
