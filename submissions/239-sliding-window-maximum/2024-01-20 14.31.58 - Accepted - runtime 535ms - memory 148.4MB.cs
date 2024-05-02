public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        List<int> result = new ();
        LinkedList<int> queue = new ();
        int left = 0, right = 0;
        while (right < nums.Length){
            // remove any smaller numbers indexes from the queue
            while (queue.Count > 0 && nums[right] > nums[queue.Last.Value])
                queue.RemoveLast();
            // append the index of the current element
            queue.AddLast(right);

            // if the left index moved dequeue the first element.
            if (left > queue.First.Value)
                queue.RemoveFirst();

            // Add first element to the result set.
            if (right + 1 >= k){
                result.Add(nums[queue.First.Value]);
                left++;
            }

            // move the cursor.
            right++;
        }

        return result.ToArray();

    }
}