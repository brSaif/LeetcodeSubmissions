public class Solution {
    public int ScheduleCourse(int[][] courses) {
        if (courses == null || courses[0].Length == 0)
            return 0;
        int runningTime = 0;
        List<int> result = new List<int>();

        var mapSorted = courses.OrderBy(x => x[1]).ThenBy(x => x[0]);
        foreach(var ele in mapSorted)
        {
            if (runningTime + ele[0] <= ele[1])
            {
                result.Add(ele[0]);
                runningTime += ele[0];
            }
            else
            {
                int max_i = 0;
                for (int i = 1; i < result.Count; i++)
                {
                    if (result.Count > 0 && result[i] > result[max_i])
                    {
                        max_i = i;
                    }
                }
                if (result.Count > 0 && result[max_i] > ele[0])
                {
                    runningTime += ele[0] - result[max_i];
                    result[max_i] = ele[0];
                }
            }
        }
        return result.Count();
    }
}