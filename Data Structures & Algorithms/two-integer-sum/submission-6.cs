public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> numToLastIndex = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++) {
            numToLastIndex[nums[i]] = i;
        }
        for (int i = 0; i < nums.Length; i++) {
            int amountNeeded = target - nums[i];
            if (numToLastIndex.ContainsKey(amountNeeded) && numToLastIndex[amountNeeded] != i) {
                return new int[]{i,numToLastIndex[amountNeeded]};
            }
        }
        return null;
    }
}
