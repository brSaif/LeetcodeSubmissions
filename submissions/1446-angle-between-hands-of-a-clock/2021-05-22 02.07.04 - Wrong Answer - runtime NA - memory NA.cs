public class Solution {
    public double AngleClock(int hour, int minutes) {
        // if(minutes == 60) hour++;
        // if(hour > 12) hour -= 12;
        double h=((hour*30)+(minutes/2))%360;
        double m=Math.Abs(h-(minutes*6));
        return Math.Min(m,Math.Abs(360-m));
        // double hrAngl = hour * 30 * 0.5;
        // double mnAngl = minutes * 0.5;
        // double ans = Math.Abs(hrAngl - mnAngl);
        // return ans;
    }
}