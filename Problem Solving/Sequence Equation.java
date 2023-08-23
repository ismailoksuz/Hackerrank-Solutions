import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Result {

    /*
     * Complete the 'permutationEquation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY p as parameter.
     */

    public static List<Integer> permutationEquation(List<Integer> p) {
        List<Integer> p1 = reverse(p);
        List<Integer> p2 = new ArrayList<Integer>();
        for(int i = 0 ; i < p1.size() ; i++){
            p2.add(p1.get(p1.get(i)-1));
        }
        return p2;

    }
    
    public static List<Integer> reverse (List<Integer> p){
        List<Integer> p1 = new ArrayList<Integer>();
        int x = 1;
        int i = 0;
        while(i < p.size()){
            if(p.get(i).equals(x)){
                p1.add(i+1);
                i = 0;
                x+=1;
            }
            else{
                i+=1;
            }
        }
        return p1;
    }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = Integer.parseInt(bufferedReader.readLine().trim());

        String[] pTemp = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        List<Integer> p = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            int pItem = Integer.parseInt(pTemp[i]);
            p.add(pItem);
        }

        List<Integer> result = Result.permutationEquation(p);

        for (int i = 0; i < result.size(); i++) {
            bufferedWriter.write(String.valueOf(result.get(i)));

            if (i != result.size() - 1) {
                bufferedWriter.write("\n");
            }
        }

        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}

