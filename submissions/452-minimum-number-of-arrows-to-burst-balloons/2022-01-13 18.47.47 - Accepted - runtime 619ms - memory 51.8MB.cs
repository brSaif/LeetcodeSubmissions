public class Solution {
    public int FindMinArrowShots(int[][] points) {
        
        // return points.OrderBy(p => p[0])
		// .ThenBy(p => p[1])
		// .Aggregate((Arrows: 0, LastArrow: long.MinValue),
		//	(t, p) => t.LastArrow >= p[0]
		//		? (t.Arrows, Math.Min(t.LastArrow, p[1]))
		//		: (t.Arrows + 1, p[1]))
		// .Arrows;
        
        if(points.Length == 0) //in order not to throw out of bounds for array
            return 0;//first sort the array
        Array.Sort(points,(x,y)=>x[1]-y[1]);//[[1,6],[2,8],[7,12],[10,16]] * 
        
        int position = points[0][1];//6
        int arrowCount =1;
        for (int i=1; i<points.Length;i++)
        {
            if(position<points[i][0] || position>points[i][1])
            {
                arrowCount++;
                position = points[i][1];
            }
        }
        return arrowCount;
    }
}