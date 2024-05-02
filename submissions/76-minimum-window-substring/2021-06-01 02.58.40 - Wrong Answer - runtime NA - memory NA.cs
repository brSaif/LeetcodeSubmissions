public class Solution {
    public string MinWindow(string s, string t) {
        
           int []m = new int[256];
 
    // Answer
    // Length of ans
    int ans = int.MaxValue;
     
    // Starting index of ans
    int start = 0;
    int count = 0, i = 0;
     
    // Creating map
    for(i = 0; i < t.Length; i++)
    {
        if (m[t[i]] == 0)
            count++;
             
        m[t[i]]++;
    }
 
    // References of Window
    i = 0;
    int j = 0;
 
    // Traversing the window
    while (j < s.Length)
    {
         
        // Calculations
        m[s[j]]--;
         
        if (m[s[j]] == 0)
            count--;
 
        // Condition matching
        if (count == 0)
        {
            while (count == 0)
            {
               
                // Soring ans
                if (ans > j - i + 1)
                {
                    ans = Math.Min(ans, j - i + 1);
                    start = i;
                }
               
                // Sliding I
                // Calculation for removing I
                m[s[i]]++;
                 
                if (m[s[i]] > 0)
                    count++;
 
                i++;
            }
        }
        j++;
    }
 
    if (ans != int.MaxValue)
        return String.Join("", s).Substring(start, ans);
    else
        return "-1";
        
    }
}