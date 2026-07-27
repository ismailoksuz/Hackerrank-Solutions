using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int lastTicket = Convert.ToInt32(Console.ReadLine());
        int waiting = Convert.ToInt32(Console.ReadLine());
        double mean = Convert.ToDouble(Console.ReadLine());
        double sDev = Convert.ToDouble(Console.ReadLine());
        double z = (lastTicket - waiting * mean) / (Math.Sqrt(waiting) * sDev);
        Console.WriteLine(NormalCDF(z).ToString("F4"));
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
