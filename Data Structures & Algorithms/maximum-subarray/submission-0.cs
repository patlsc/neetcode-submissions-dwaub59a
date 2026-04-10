public class Solution {
    public int MaxSubArray(int[] nums) {
        /*
        we need to find the optimal start and end points for the highest total sum
        for each point, consider what happens if it's the end point
        if it is the end point but the next value is zero or above, we can also consider [...xi,xi+1]
        if the next value is negative, 


        any existing solution has to start and end on a positive number, else it could be optimized further

        */
        int globalMaximum = Int32.MinValue;
        int optimalSumThusFar = 0;
        for (int i = 0; i < nums.Length; i++) {
            optimalSumThusFar = System.Math.Max(nums[i],optimalSumThusFar+nums[i]);
            globalMaximum = System.Math.Max(globalMaximum,optimalSumThusFar);
        }
        return globalMaximum;
    }
}
