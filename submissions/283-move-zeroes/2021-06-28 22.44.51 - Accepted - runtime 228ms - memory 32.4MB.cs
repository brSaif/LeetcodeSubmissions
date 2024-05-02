public class Solution {
    public void MoveZeroes(int[] nums) {
        int zcount = 0;
        int len = nums.Length;
        for(int i =0; i < len; i++){
            if(nums[i] == 0){
                zcount++;
                continue;
            }
            nums[i - zcount] = nums[i];
        }
        while(zcount > 0){
            nums[len -1] = 0;
            len --;
            zcount--;
        }
    }
}