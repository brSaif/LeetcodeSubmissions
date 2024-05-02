public class Solution {
    public int CompareVersion(string version1, string version2) {
        
        var str1 = version1.Split('.');
        var str2 = version2.Split('.');
        
        int n = Math.Max(str1.Length, str2.Length);
        for (int i = 0; i < n; i++){
            var v1 = int.Parse(i < str1.Length ? str1[1] : "0");
            var v2 = int.Parse(i < str2.Length ? str2[1] : "0");
            
            if (v1 > v2) return 1;
            else if (v1 < v2) return -1;
        }
        
        return 0;
    }
}