public class Solution {
    public string ReversePrefix(string word, char ch) {
       int h = word.Length - 1;
       int l = 0;
        var arr = word.ToCharArray();
       while(h > l)
       {
            if (arr[l] != ch)
            {
                l++ ;
                continue;
            }

            h = l;
            l = 0;
            break;
       }

       while (h > l) 
       {
         (arr[h], arr[l]) = (arr[l], arr[h]);
         h--;
         l++;
       }

       return new string(arr);
    }
}