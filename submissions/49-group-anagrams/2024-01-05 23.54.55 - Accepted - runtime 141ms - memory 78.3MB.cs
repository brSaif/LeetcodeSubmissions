public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, IList<string>>();

        foreach(var str in strs)
        {
            var keyArr = str.ToCharArray();
            Array.Sort(keyArr);
            var newKey = new String(keyArr);
            if(dict.ContainsKey(newKey))
            {
                dict[newKey].Add(str);
            }else
            {
                dict.Add(newKey, new List<string>(){str});
            }
        }
        return dict.Values.ToList();
    
    }
}