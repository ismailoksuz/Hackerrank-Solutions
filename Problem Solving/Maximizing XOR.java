import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Result {

    /*
     * Complete the 'maximizingXor' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER l
     *  2. INTEGER r
     */

    public static int maximizingXor(int l, int r) {
        List<String> elements = new ArrayList<String>();
        for(int i = l ; i <= r ; i++){
            elements.add(Integer.toBinaryString(i));
        }
        return Integer.parseInt(getMax(elements), 2);
    }
    
    public static String XOR (String a, String b){
        String longer = a;
        String shorter = b;
        if(b.length()>a.length()){
            longer = b;
            shorter = a;
        }
        int dif = longer.length() - shorter.length();
        String extra = "";
        for(int i = 0 ; i < dif ; i++){
            extra += "0";
        }
        shorter = extra + shorter;
        String xor = "";
        for(int i = 0 ; i < longer.length(); i++){
            if(longer.charAt(i) == shorter.charAt(i)){
                xor += "0";
            }
            else{
                xor += "1";
            }
        }
        return xor;
    }
    
    public static String getMax (List<String> b){
        int max = 0;
        for(int i = 0 ; i < b.size() ; i++){
            for(int j = i+1 ; j < b.size() ; j++){
                if(Integer.parseInt(XOR(b.get(i),b.get(j)))>max){
                    max = Integer.parseInt(XOR(b.get(i),b.get(j)));
                }
            }
        }
        return String.valueOf(max);
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int l = Integer.parseInt(bufferedReader.readLine().trim());

        int r = Integer.parseInt(bufferedReader.readLine().trim());

        int result = Result.maximizingXor(l, r);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}

