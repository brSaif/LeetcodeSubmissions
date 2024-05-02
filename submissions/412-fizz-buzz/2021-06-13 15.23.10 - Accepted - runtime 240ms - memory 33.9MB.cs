public class Solution {
    public IList<string> FizzBuzz(int n) {
        IList<string> fizzList = new List<string>();
        
        for(int i = 1; i <= n;i++){
            string str = ""; 
            if(i % 3 == 0 && i % 5 == 0){
                str = "FizzBuzz";
                fizzList.Add(str);
            }else if(i % 3 == 0){
                str = "Fizz";
                fizzList.Add(str);
            }else if(i % 5 == 0){
                str = "Buzz";
                fizzList.Add(str);
            }else{
                str = i.ToString();
                fizzList.Add(str);
            }
        }
        
        return fizzList;
    }
}