public class Solution {
    public bool CanJump(int[] nums) {
        /*
        let's say a certain index could get us to the end
        then every index that can reach that index, can also get us to the end
        
        */
        HashSet<int> canReachEndIndices = new HashSet<int>();
        for (int i = nums.Length-1; i >= 0; i--) {
            if (i+nums[i]>=nums.Length-1) {
                //if we can get to the end directly
                canReachEndIndices.Add(i);
            }
            if (nums[i] == 0) {
                continue;
            }
            for (int k = 1; k <= nums[i]; k++) {
                if (canReachEndIndices.Contains(i+k)) {
                    //we can reach a point that can go to the end
                    canReachEndIndices.Add(i);
                }
            }
        }
        return canReachEndIndices.Contains(0);
    }
}
