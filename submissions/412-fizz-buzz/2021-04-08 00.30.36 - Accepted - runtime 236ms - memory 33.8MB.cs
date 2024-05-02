public class Solution {
    public IList<string> FizzBuzz(int n) {
        string[] fizzBuzz = new string[n];
        int i = 0;
        while(i < n ){
            int k = 1 +i;
            if((k % 3 == 0) && (k % 5 == 0)) {fizzBuzz[i] = "FizzBuzz";}
            else if(k % 3 == 0) {fizzBuzz[i] = "Fizz";}
            else if(k % 5 == 0) {fizzBuzz[i] = "Buzz";}
            else {
                fizzBuzz[i] = k.ToString();
            }
            i++;
        }
        
        return fizzBuzz ;
    }
}