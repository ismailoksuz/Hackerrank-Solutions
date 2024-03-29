using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    
    static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        int temp=0;
        for(var i=0;i<keyboards.Count();i++){
            for(var j=0;j<drives.Count();j++){
                if(keyboards[i]+drives[j]<=b){
                    if(keyboards[i]+drives[j]>temp){
                        temp=keyboards[i]+drives[j];
                    }
                }
            }
        }
        if(temp!=0)return temp;
        else return -1;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
