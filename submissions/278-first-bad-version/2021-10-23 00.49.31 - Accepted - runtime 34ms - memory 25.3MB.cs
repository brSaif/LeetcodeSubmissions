/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        int l = 1, h = n;
        while(l < h){
            int mid = l + (h -l) / 2;
            if(IsBadVersion(mid)){h = mid ;}
            else{l = mid + 1;}
        }
        return l;
    }
}