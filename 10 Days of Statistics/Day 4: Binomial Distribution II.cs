using System;

class Solution {
    static void Main(String[] args) {
        string[] input = Console.ReadLine().Split(' ');
        double p = Convert.ToDouble(input[0]) / 100;
        int n = Convert.ToInt32(input[1]);

        double noMoreThanTwo = 0;
        for (int i = 0; i <= 2; i++) {
            noMoreThanTwo += BinomialProbability(n, i, p);
        }

        double atLeastTwo = 0;
        for (int i = 2; i <= n; i++) {
            atLeastTwo += BinomialProbability(n, i, p);
        }
        Console.WriteLine(Math.Round(noMoreThanTwo, 3).ToString("F3"));
        Console.WriteLine(Math.Round(atLeastTwo, 3).ToString("F3"));
    }

    static double BinomialProbability(int n, int k, double p) {
        return Combination(n, k) * Math.Pow(p, k) * Math.Pow(1 - p, n - k);
    }

    static double Combination(int n, int k) {
        if (k < 0 || k > n) return 0;
        if (k == 0 || k == n) return 1;
        if (k > n / 2) k = n - k;
        double com = 1.0;
        for (int i = 1; i <= k; i++) {
            com = com * (n - i + 1) / i;
        }
        return com;
    }
}
