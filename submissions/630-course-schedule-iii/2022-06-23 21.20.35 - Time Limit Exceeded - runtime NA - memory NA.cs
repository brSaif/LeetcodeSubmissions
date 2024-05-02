public class Solution {
    public int ScheduleCourse(int[][] courses) {
        
        Array.Sort(courses, (a, b) => a[1] - b[1]);
        int len = courses.Length;
        var memo = new int[len, courses[len-1][1] + 1];
        
        return Schedule(courses, 0, 0, memo);
    }
    
    private int Schedule(int[][] courses, int i, int time, int[,] memo){
        if (i == courses.Length)
            return 0;
        
        if (memo[i, time] != 0)
            return memo[i, time];
        int taken = 0;
        if (time + courses[i][0] <= courses[i][1])
            taken = 1 + Schedule(courses, i + 1, time + courses[i][0], memo);
        
        int notTaken = Schedule(courses, i + 1, time, memo);
        memo[i, time] = Math.Max(taken, notTaken);
        return memo[i, time];
    }
}