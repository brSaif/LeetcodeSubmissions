public class Solution {
    public string RemoveDuplicateLetters(string s) {
        
        Dictionary<char, int> dic = new Dictionary<char, int>();
        HashSet<char> set = new HashSet<char>();

        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(!dic.TryAdd(s[i],i))
            {
                dic[s[i]] = i;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            //using monotonic stack
            if(!set.Contains(s[i]))
            {
                while(stack.Any() && stack.Peek() > s[i] && dic[stack.Peek()] > i)
                {
                    set.Remove(stack.Pop());
                }

                set.Add(s[i]);
                stack.Push(s[i]);
            }
        }
        
        var sb = new StringBuilder();
        foreach(var v in stack.Reverse()){
            sb.Append(v);
        }
        
        return sb.ToString();
    }
}