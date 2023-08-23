import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Result {

    /*
     * Complete the 'appendAndDelete' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     *  3. INTEGER k
     */

    public static String appendAndDelete(String s, String t, int k) {
        if(s.equals(t)){
            if(k>=s.length()+t.length()){
                return ("Yes");
            }
            else if(k%2==0){
                return ("Yes");
            }
            return ("No");
        }
        char[] arr = s.toCharArray();
        char[] arr2 = t.toCharArray();
        int sames = minSatisfy(arr, arr2);
        int needed = s.length() + t.length() - sames*2;
        if(k>=s.length()+t.length()){
            return ("Yes");
        }
        else if((k-needed)%2==0 && k>=needed){
            return ("Yes");
        }
        else{
            return("No");
        }

    }
    
    public static int minSatisfy(char[] s, char[] k){
        int sames = 0;
        int min = s.length;
        if(k.length < min){
            min = k.length;
        }
        for(int i = 0 ; i < min ; i++){
            if(s[i] == k[i]){
                sames+=1;
            }
            else{
                break;
            }
        }
        return sames;
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = bufferedReader.readLine();

        String t = bufferedReader.readLine();

        int k = Integer.parseInt(bufferedReader.readLine().trim());

        String result = Result.appendAndDelete(s, t, k);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}

