public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
         return strs.GroupBy(x => string.Concat(x.OrderBy(c => c))).Select(x => (IList<string>)x.ToList()).ToList();
    }
}