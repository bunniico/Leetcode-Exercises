public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int arrayIndex = 1;
        int preValue = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != preValue)
            {
                nums[arrayIndex++] = nums[i];
                preValue = nums[i];
            }
        }
        return arrayIndex;
    }
}