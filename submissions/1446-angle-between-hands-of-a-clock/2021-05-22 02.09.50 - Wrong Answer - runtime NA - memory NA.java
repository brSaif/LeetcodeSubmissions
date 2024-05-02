class Solution {
    public double angleClock(int hour, int minutes) {
        hour = hour % 12; // 12 o'clock is 0.
        
        double hourHandLocation = hour * 30;
        hourHandLocation += (minutes * 6);
        
        double minHandLocation = minutes * 0.5;
        
        double diff = Math.abs(hourHandLocation - minHandLocation);
        
        // return the smallest angle.
        return Math.min(diff, 360 - diff);
    }
}