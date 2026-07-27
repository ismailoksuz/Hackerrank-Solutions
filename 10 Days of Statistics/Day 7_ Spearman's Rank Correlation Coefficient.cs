using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int size = Convert.ToInt32(Console.ReadLine());
        string[] inpX = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
        string[] inpY = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
        double[] setX = Array.ConvertAll(inpX, double.Parse);
        double[] setY = Array.ConvertAll(inpY, double.Parse);
        Console.WriteLine(spearmanRankC(setX, setY).ToString("F3"));
    }
    static double spearmanRankC (double[] setX, double[] setY){
        int[] rankX = getRanks(setX);
        int[] rankY = getRanks(setY);
        int n = setX.Length;
        double d = 0;
        for(int i = 0 ; i < setX.Length ; i++){
            d += Math.Pow(rankX[i]-rankY[i],2);
        }
        return 1-((6*d)/(n*(n*n-1)));

    }
    static int[] getRanks (double[] arr){
        double[] sorted = arr.Distinct().OrderBy(x => x).ToArray();
        Dictionary<double, int> rankMap = new Dictionary<double, int>();
        for (int i = 0; i < sorted.Length; i++)
        {
            rankMap[sorted[i]] = i + 1;
        }
        return arr.Select(x => rankMap[x]).ToArray();
    }
}
