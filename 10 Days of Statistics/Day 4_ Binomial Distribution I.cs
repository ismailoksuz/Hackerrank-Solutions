using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] input = Console.ReadLine().Split(' ');
        double gp = Convert.ToDouble(input[0]);
        double bp = Convert.ToDouble(input[1]);
        double p = gp / (bp + gp);
        double threeBoiz = 0;
        for(int i = 3; i <= 6 ; i++){
            threeBoiz += binomial(6,i,p);
        }
        Console.WriteLine(threeBoiz.ToString("F3"));
    }
    static double binomial(int n, int k, double p) {
        return combination(n, k) * Math.Pow(p, k) * Math.Pow(1 - p, n - k);
    }
    static double combination(int n, int k) {
        if (k > n - k) k = n - k;
        double c = 1.0;
        for (int i = 0; i < k; i++) {
            c *= (n - i) / (double)(i + 1);
        }
        return c;
    }
}