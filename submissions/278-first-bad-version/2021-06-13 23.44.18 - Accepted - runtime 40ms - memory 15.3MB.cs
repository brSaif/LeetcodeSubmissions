/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if (n==1) return 1;
        int begin = 1;
        int end = n;
        while (begin < end){
            int mid = begin + (end - begin) / 2;
            if (IsBadVersion(mid)) {
                end = mid;
            }
            else{
                begin = mid + 1;
            }
        }
        return begin;
         
    }
}