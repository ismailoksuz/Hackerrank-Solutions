using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string[] inputs = Console.ReadLine().TrimEnd().Split(' ');
        List<int> values = new List<int>();
        foreach(string item in inputs){
            values.Add(Convert.ToInt32(item));
        }
        values.Sort();
        Console.WriteLine(getMean(values));
        Console.WriteLine(getMedian(values));
        Console.WriteLine(getMode(values));

    }
    static double getMean (List<int> values){
        double sum = 0.0;
        foreach(int item in values){
            sum += (double)item;
        }
        return (sum/(double)(values.Count));
    }
    static double getMedian (List<int> values){
        if((values.Count)%2 == 1){
            return (double)values[(values.Count)/2];
        }
        else{
            return ((double)(values[(values.Count)/2] + values[((values.Count)/2)-1])/2);
        }
    }
    static int getMode (List<int> values){
        var frequency = values.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        List<int> occurences = frequency.Values.ToList();
        int maxFreq = occurences.Max();
        List<int> indexes = new List<int>();
        for(int i = 0 ; i < frequency.Count ; i++){
            if(frequency.ElementAt(i).Value==maxFreq){
                indexes.Add(frequency.ElementAt(i).Key);
            }
        }
        return indexes.Min();
    }
    
    
}
