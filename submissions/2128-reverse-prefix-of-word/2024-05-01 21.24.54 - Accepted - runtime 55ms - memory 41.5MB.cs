public class Solution {
    public string ReversePrefix(string word, char ch) {
        var stk = new Stack<char>();
        var shouldFlip = false;
        foreach (var n in word)
        {
            if (n == ch)
            {
                stk.Push(n);
                shouldFlip = true;
                break;
            }
            stk.Push(n);
        }

        if (!shouldFlip)
            return word;

        var arr = word.ToCharArray();
        var index = 0;

        while (stk.Count > 0)
        {
            arr[index] = stk.Pop();
            index++;
        }

        return new string (arr);

    }
}