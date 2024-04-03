// https://leetcode.com/problems/product-of-array-except-self/description/

int[] nums = [1, 2, 3, 4];
// int[] nums = [-1,1,0,-3,3];

int[] answer = ProductExceptSelf(nums);


static int[] ProductExceptSelf(int[] nums) {
    int[] left = new int[nums.Length];
    int[] right = new int[nums.Length];
    Array.Fill(left, 1);
    Array.Fill(right, 1);

    return left;
}
