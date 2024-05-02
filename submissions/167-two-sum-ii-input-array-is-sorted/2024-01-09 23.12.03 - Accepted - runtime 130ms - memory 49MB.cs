public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        while (right > left){
            var diff = target - numbers[left];
            if (diff == numbers[right])
                return new int[]{++left, ++right};
            else if (numbers[right] + numbers[left] > target)
                right--;
            else
                left++;
        }
        return new int[]{};
    }
}