using System;

class Solution {
    static void Main(String[] args) {
        string[] inp1 = Console.ReadLine().Split(' ');
        double mean = Convert.ToDouble(inp1[0]);
        double sDev = Convert.ToDouble(inp1[1]);
        double q1 = Convert.ToDouble(Console.ReadLine());
        string[] inp2 = Console.ReadLine().Split(' ');
        double lowBound = Convert.ToDouble(inp2[0]);
        double upBound = Convert.ToDouble(inp2[1]);
        double p1 = NormalCDF(mean, sDev, q1);
        double p2 = NormalCDF(mean, sDev, upBound) - NormalCDF(mean, sDev, lowBound);
        Console.WriteLine(p1.ToString("F3"));
        Console.WriteLine(p2.ToString("F3"));
    }
    static double NormalCDF(double mean, double sDev, double x) {
        return 0.5 * (1 + Erf((x - mean) / (sDev * Math.Sqrt(2))));
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
