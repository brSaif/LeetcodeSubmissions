class Solution {
    public double angleClock(int hour, int minutes) {
        double h=((hour*30)+(minutes/2))%360;
        double m=Math.abs(h-(minutes*6));
        return Math.min(m,Math.abs(360-m));
    }
}