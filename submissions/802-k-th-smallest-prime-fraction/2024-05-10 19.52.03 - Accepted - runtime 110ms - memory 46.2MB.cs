public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k) {
        int n = arr.Length;
        double left = 0, right = 1;
        int[] result = new int[2];

        while (right - left > 1e-9) {
            double mid = (left + right) / 2;
            int count = 0;
            double maxFraction = 0;
            int numerator = 0, denominator = 0;

            for (int i = 0, j = 1; i < n - 1; i++) {
                while (j < n && arr[i] > mid * arr[j]) {
                    j++;
                }
                count += n - j;
                if (j < n && maxFraction < (double)arr[i] / arr[j]) {
                    maxFraction = (double)arr[i] / arr[j];
                    numerator = arr[i];
                    denominator = arr[j];
                }
            }

            if (count == k) {
                result[0] = numerator;
                result[1] = denominator;
                break;
            }
            else if (count < k) {
                left = mid;
            }
            else {
                right = mid;
            }
        }

        return result;
    }
}