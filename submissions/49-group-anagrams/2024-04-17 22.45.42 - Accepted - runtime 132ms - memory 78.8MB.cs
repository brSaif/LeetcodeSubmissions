public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, IList<string>>();

        foreach (var str in strs){
            var keyArr = str.ToCharArray();
            Array.Sort(keyArr);
            var key = new string(keyArr);


            if (res.ContainsKey(key))
                 res[key].Add(str);

            else
                res.Add(key, new List<string>(){str});
        }

        return res.Values.ToList();
    }
}