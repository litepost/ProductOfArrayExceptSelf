// https://leetcode.com/problems/product-of-array-except-self/description/

using System.Runtime.InteropServices;

// int[] nums = [1, 2, 3, 4]; // [24, 12, 8, 6]
int[] nums = [-1,1,0,-3,3]; // [0, 0, 9, 0, 0]

int[] answer = ProductExceptSelf(nums);
Console.WriteLine($"[{string.Join(",", answer)}]");


static int[] ProductExceptSelf(int[] nums) {
    if (nums.Length < 2) return nums;
    
    int[] left = new int[nums.Length];
    int[] right = new int[nums.Length];
    int[] output = new int[nums.Length];

    Array.Fill(left, 1);
    Array.Fill(right, 1);

    for (int i = 1; i < nums.Length; i++) {
        left[i] = left[i-1] * nums[i-1];
    }

    for (int i = nums.Length-2; i >= 0; i--) {
        right[i] = right[i+1] * nums[i+1];
    }
    for (int i = 0; i < nums.Length; i++) {
        output[i] = left[i] * right[i];
    }

    return output;
}
