public class Solution {
    public int Reverse(int x) {
        char[] strArr = x.ToString().ToCharArray();
        if(x <= Int32.MaxValue &&
           x >= Int32.MinValue){
            if(x >= 0)  
                Array.Reverse(strArr) ;
            else 
                Array.Reverse(strArr,1,strArr.Length - 1);
            Console.WriteLine(x);
            var res = new String(strArr);
            return Convert.ToInt32(res);
        }
        return 0;
    }
}