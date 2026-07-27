using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] input = Console.ReadLine().Split(' ');
        double high = Convert.ToDouble(Console.ReadLine());
        double low = Convert.ToDouble(Console.ReadLine());
        double mean = Convert.ToDouble(input[0]);
        double sDev = Convert.ToDouble(input[1]);
        double z1 = (high-mean)/sDev;
        double z2 = (low-mean)/sDev;
        double p1 = 1 - NormalCDF(z1);
        double p2 = 1 - NormalCDF(z2);
        double p3 = NormalCDF(z2);
        Console.WriteLine((p1 * 100).ToString("F2"));
        Console.WriteLine((p2 * 100).ToString("F2"));
        Console.WriteLine((p3 * 100).ToString("F2"));
    }
    static double NormalCDF(double z) {
        return 0.5 * (1 + Erf(z / Math.Sqrt(2)));
    }
    static double Erf(double x) {
        double a1 = 0.254829592, a2 = -0.284496736, a3 = 1.421413741;
        double a4 = -1.453152027, a5 = 1.061405429;
        double p = 0.3275911;
        double sign = (x < 0) ? -1 : 1;
        x = Math.Abs(x);
        double t = 1.0 / (1.0 + p * x);
        double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);
        return sign * y;
    }
}
