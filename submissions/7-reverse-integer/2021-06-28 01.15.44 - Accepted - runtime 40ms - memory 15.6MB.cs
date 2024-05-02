public class Solution {
    public int Reverse(int x) {
        char[] chr = x.ToString().ToCharArray();
        int ans;
        // check sig(-/+)
        if(x >= 0){
            Array.Reverse(chr);
        }else{
            Array.Reverse(chr, 1, chr.Length - 1);
        }
        var str = new string(chr);
        // try parse result
        try{
            ans = int.Parse(str);
        }catch(Exception){
            ans = 0;
        }
        return ans;
    }
}