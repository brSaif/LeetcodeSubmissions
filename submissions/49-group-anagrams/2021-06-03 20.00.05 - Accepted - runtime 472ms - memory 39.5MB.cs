public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
         // return strs.GroupBy(x => string.Concat(x.OrderBy(c => c))).Select(x => (IList<string>)x.ToList()).ToList();
        
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var key = str.ToCharArray();
                Array.Sort(key);
                string newKey = new string(key);
                if (!dict.TryGetValue(newKey, out var temp))
                {
                    temp = dict[newKey] = new List<string>();
                }
                temp.Add(str);
            }

            List<IList<string>> res = new List<IList<string>>(dict.Values.ToList());
            return res;
    }
}