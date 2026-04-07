public class Solution {
    public int LongestConsecutive(int[] nums) {
        //naive solution is sort (nlogn) and look through for longest sequence
        //we could also put nums through a value->index dictionary and then "build up" the sequence from each starting point
        //starting only at 'starter' nums where x-1 isn't in the array
        Dictionary<int,int> valueToIndex = new Dictionary<int,int>();
        int maxSequenceLength = 0;
        for (int i = 0; i < nums.Length; i++) {
            valueToIndex[nums[i]] = i;
        }
        for (int i = 0; i < nums.Length; i++) {
            //if this is a starting number for a sequence
            if (!valueToIndex.ContainsKey(nums[i]-1)) {
                //build up a consecutive sequence until we can't, then record the length of the sequence
                int currentVal = nums[i];
                int currentIndex = i;
                int currentSequenceLength = 1;
                while (valueToIndex.ContainsKey(currentVal+1)) {
                    currentSequenceLength++;
                    currentIndex = valueToIndex[currentVal+1];
                    currentVal = nums[currentIndex];
                }
                //record length we got
                maxSequenceLength = currentSequenceLength > maxSequenceLength ? currentSequenceLength : maxSequenceLength;
            }
        }
        return maxSequenceLength;
    }
}