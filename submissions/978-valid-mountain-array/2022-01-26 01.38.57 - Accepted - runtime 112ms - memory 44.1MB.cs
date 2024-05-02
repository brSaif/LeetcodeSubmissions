public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if (arr.Length < 3)
            {
                return false;
            }

            var increasingFound = false;
            var foundSummit = false;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] < arr[i])
                {
                    foundSummit = true;
                }

                if (!foundSummit)
                {
                    increasingFound = true;
                    if (arr[i + 1] <= arr[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (arr[i + 1] >= arr[i])
                    {
                        return false;
                    }
                }

            }

            return foundSummit && increasingFound;
    }
}