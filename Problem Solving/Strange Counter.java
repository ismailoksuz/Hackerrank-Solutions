import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Result {

    /*
     * Complete the 'strangeCounter' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER t as parameter.
     */

    public static long strangeCounter(long t) {
        return(getSum(t) - t);

    }
    
    public static long getSum (long t){
        long cycle = getCycle(t);
        long sum = 4;
        if(cycle == 1){
            return sum;
        }
        for(int i = 1 ; i < cycle ; i++){
            sum += 3*getExp(i);
        }
        return sum;
        
    }
    
    public static long getCycle (long t){
        int i = 0;
        while(t > 0){
            t -= 3*getExp(i);
            i += 1;
        }
        return i;
    }
    public static long getExp (long e){
        long res = 1;
        for(int i = 0 ; i < e ; i++){
            res*=2;
        }
        return res;
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        long t = Long.parseLong(bufferedReader.readLine().trim());

        long result = Result.strangeCounter(t);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}

