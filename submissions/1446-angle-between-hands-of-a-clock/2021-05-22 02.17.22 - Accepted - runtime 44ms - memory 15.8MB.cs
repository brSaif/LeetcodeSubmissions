public class Solution {
    public double AngleClock(int hour, int minutes) {
        if(minutes == 60) hour++;
        if(hour > 12) hour -= 12;
        double hrAngl = hour * 30 + 0.5 * minutes;
        double mnAngl = minutes * 6;
        double ans = Math.Abs(hrAngl - mnAngl);
        return Math.Min(ans,360 - ans);
    }
}