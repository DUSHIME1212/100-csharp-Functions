// 169. Majority Element
//     Easy
// Topics
//     premium lock icon
//     Companies
// Given an array nums of size n, return the majority element.
//
//     The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
//
//  
//
//     Example 1:
//
// Input: nums = [3,2,3]
// Output: 3
// Example 2:
//
// Input: nums = [2,2,1,1,1,2,2]
// Output: 2
//  
//
// Constraints:
//
// n == nums.length
// 1 <= n <= 5 * 104
//     -109 <= nums[i] <= 109
//  
//
// Follow-up: Could you solve the problem in linear time and in O(1) space?


// The optimal approach to solve this problem is by using the Boyer-Moore Voting Algorithm. This algorithm works by maintaining a candidate for the majority element and a count. The algorithm iterates through the array, and for each element, it either increments the count if the current element matches the candidate or decrements the count otherwise. If the count reaches zero, the algorithm updates the candidate to the current element and resets the count to one. The candidate remaining at the end of the iteration is the majority element because it has survived the elimination process where other elements cancel each other out.

public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0;
        int candidate = nums[0];
        
        foreach (int num in nums) {
            if (count == 0) {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }
        
        return candidate;
    }
}

class Program {
    static void Main(string[] args) {
        Solution solution = new Solution();
        Console.WriteLine(solution.MajorityElement(new int[] {3, 2, 3})); // Output: 3
        Console.WriteLine(solution.MajorityElement(new int[] {2, 2, 1, 1, 1, 2, 2})); // Output: 2
    }
}