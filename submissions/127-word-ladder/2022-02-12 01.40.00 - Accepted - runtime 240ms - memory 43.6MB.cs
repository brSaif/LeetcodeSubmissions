public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
                int count = 1,
            countInLevel = 0;
        Queue<string> queue = new Queue<string>();
        string currentWord = string.Empty;
        HashSet<string> dictionary = new HashSet<string>(wordList);
        char[] temp = null;
        
        queue.Enqueue(beginWord);
        
        while (queue.Count != 0)
        {
            countInLevel = queue.Count();
            
            while (countInLevel-- > 0)
            {
                currentWord = queue.Dequeue();
                
                if (currentWord == endWord)
                    return count;
                
                temp = currentWord.ToCharArray();
                for (int i = 0; i <= temp.Length - 1; i++)
                {
                    temp = currentWord.ToCharArray();

                    for (int j = 0; j < 26; j++)
                    {
                        temp[i] = (char)('a' + j);

                        if (dictionary.Contains(new string(temp)))
                        {
                            queue.Enqueue(new string(temp));
                            dictionary.Remove(new string(temp));
                        }
                    }
                }
            }
            
            count++;
        }
        
        return 0;
    }
}