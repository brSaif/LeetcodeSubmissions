public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits.Length == 0) return digits;
        IList<int> res = new List<int>();
        string sum = "";
        foreach(int n in digits){
            sum += n;
        }
        double nums = Convert.ToDouble(sum) + 1;
        
        string sumStr = nums.ToString();
        foreach(char c in sumStr){
            int v =  (int)Char.GetNumericValue(c);
            res.Add(v);
        }
        return res.ToArray();
    }
}