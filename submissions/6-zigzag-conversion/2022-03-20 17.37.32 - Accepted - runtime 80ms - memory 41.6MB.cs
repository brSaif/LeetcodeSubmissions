public class Solution {
    public string Convert(string s, int numRows) {
         if (numRows==1) return s;

        StringBuilder[] listArray = new StringBuilder[numRows];
        for (int i=0;i<numRows;i++){
            listArray[i] = new StringBuilder();
        }

        int len = s.Length;

        int direction = 0; 
        for (int i=0, index=0; i< len; i++) {
            char c = s[i];


            if (direction == 0) {
                bool end = index >= (numRows-1); 
                if (end) {
                    direction = 1;
                }
                listArray[index].Append(c);
                index = end ? (index-1):(index+1);
            } else{
                bool top = index<=0;
                if (top) {
                    direction = 0;
                }
                listArray[index].Append(c);
                index = top? index+1:index-1;
            }

        }

        StringBuilder result = new StringBuilder();
        for(int i=0;i<numRows;i++){
            result.Append(listArray[i].ToString());
        }
        return result.ToString();
    }
}