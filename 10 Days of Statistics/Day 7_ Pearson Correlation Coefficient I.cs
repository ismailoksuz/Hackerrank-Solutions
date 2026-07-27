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
        Console.WriteLine(pearsonCC(setX,setY).ToString("F3"));
    }
    static double pearsonCC (double[] setX, double[] setY){
        double meanX = calculateMean(setX);
        double meanY = calculateMean(setY);
        double sDevX = calculateStdDev(setX, meanX);
        double sDevY = calculateStdDev(setY, meanY);
        double numx = 0;
        for(int i = 0 ; i < setX.Length ; i++){
            numx += (setX[i]-meanX)*(setY[i]-meanY);
        }
        return numx/(setX.Length*sDevX*sDevY);
    }
    static double calculateStdDev (double[] arr, double mean){
        double sDev = 0;
        for(int i = 0 ; i < arr.Length ; i++){
            sDev += Math.Pow(arr[i]-mean,2);
        }
        return Math.Sqrt(sDev/arr.Length);
    }
    static double calculateMean (double[] arr){
        double sum = 0;
        foreach(double val in arr){
            sum += val;
        }
        return sum/arr.Length;
    }
}
