public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
    if (capacity == 0) {
        return false;
    }
    if (trips.Length == 0) {
        return true;
    }
    int count = 0;
    Dictionary < int, int > In = new Dictionary < int, int > ();
    Dictionary < int, int > Out = new Dictionary < int, int > ();
    int start = Int32.MaxValue;
    int end = Int32.MinValue;
    foreach(var trip in trips) {
        int currentCount = trip[0];
        if (!In.ContainsKey(trip[1])) {
            In.Add(trip[1], 0);
        }
        start = Math.Min(start, trip[1]);// set start point
        In[trip[1]] += currentCount;//track the number of passengers who get on at that point
        if (!Out.ContainsKey(trip[2])) {
            Out.Add(trip[2], 0);
        }
        Out[trip[2]] += currentCount;;//track the number of passengers who get off at that point 
        end = Math.Max(end, trip[2]);//set end point
    }

    for (int i = start; i <= end; i++) {
        if (In.ContainsKey(i)) {
            count += In[i]; //add number of passengers who get on
        }
        if (Out.ContainsKey(i)) {
            count -= Out[i];//remove number of passengers who get off
        }
        if (count > capacity) {
            return false;
        }

    }

    return true;
}

}