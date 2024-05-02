public class Solution {
    public int ScheduleCourse(int[][] courses) {
          Array.Sort(courses, (a, b) => a[1].CompareTo(b[1]));     
        
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        
        var days = 0;
        
        for(int i = 0; i< courses.Length; i++)
        {
            // if(courses[i][0]<=courses[i][1])
            // {
                queue.Enqueue(courses[i][0],0-courses[i][0]);
                days+=courses[i][0];    
                if(days>courses[i][1]) 
                {
                    var nodeToRemove = queue.Dequeue();
                    days-=nodeToRemove;
                }
            // }
        }
        return queue.Count;
    }
}