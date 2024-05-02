public class Solution {
    public bool CheckInclusion(string s1, string s2) {
         if (s1.Length > s2.Length) {
            return false;
        }
        var sig1 = new Counter<char>(s1);
        var sig2 = new Counter<char>(s2.Substring(0, s1.Length));
        var i = 0;
        while (i + s1.Length - 1 < s2.Length) {
            if (sig1.Equals(sig2)) {
                return true;
            }
            sig2[s2[i]]--;
            if (i + s1.Length < s2.Length) {
                sig2[s2[i + s1.Length]]++;
            }
            i++;
        }
        return false;
    }
    
    public class Counter<T> {
        Dictionary<T, int> dict;
        
        public int this[T key] {
            get => dict.ContainsKey(key) ? dict[key] : 0;
            set {
                if (value > 0) { dict[key] = value; }
                else { dict.Remove(key); }
            }
        }
        
        public ICollection<T> Keys => dict.Keys;
        
        public Counter(IEnumerable<T> items) {
            dict = items.GroupBy(i => i).ToDictionary(g => g.Key, g => g.Count());
        }
        
        public bool Equals(Counter<T> other) {
            return this.dict.Keys.ToHashSet().SetEquals(other.dict.Keys.ToHashSet())
                && this.dict.Keys.All(key => this.dict[key] == other.dict[key]);
        }
    }
}