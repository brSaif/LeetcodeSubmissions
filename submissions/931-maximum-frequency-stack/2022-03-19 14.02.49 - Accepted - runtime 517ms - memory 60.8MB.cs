public class FreqStack {

    Dictionary<int, int> freq;
    Dictionary<int, Stack<int>> group;
    int maxfreq;

    public FreqStack() {
        freq = new Dictionary<int, int>();
        group = new Dictionary<int, Stack<int>>();
        maxfreq = 0;        
    }
    
    public void Push(int val) {
        int f = (freq.ContainsKey(val) ? freq[val] : 0) + 1;
        freq[val] = f;
        if (f > maxfreq) {
            maxfreq = f;
        }
        if (!group.ContainsKey(f)) {
            group[f] = new Stack<int>();
        }
        group[f].Push(val);         
    }
    
    public int Pop() {
        int x = group[maxfreq].Pop();
        freq[x]--;
        if (group[maxfreq].Count == 0) {
            maxfreq--;
        }
        return x;        
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */