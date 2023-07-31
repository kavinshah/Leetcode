/*

2,6
4,8,10
9,15
left=2,  right=4

1,2,3,4
0

1
0

2,3,4,8,10
9,15
left=5, right=4

2,4,5,6
3,8,9,10
left=4, right=3

1,2,3,6
4,5,7,8
left=4, right=3

2,1,5,3,4
2
1,5
3,4


find point from start upto which the array is in increasing order
find the point from the end upto which array is in decreasing order

find the min and max of the subarray

find the element from the left subarray which falls within the min-max range

find the element from the right subarray which falls within the min-max range

1,2,3,6
4,5,7,8
left=4, right=3

2,6
4,8,10
9,15
left=2, right=4

2,1,5,3,4
2
1,5
3,4

1,3,5,4,2
1,3,5
4
2

[2,1,5,3,4]
[1,3,2,3,3]
[1,2,3,3,3]

2,4,3,5,1
2,4
3,5
1



*/


public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int left=0;
        int right = nums.Length-1;
        int leftMax=0, rightMin=nums.Length-1;
        int leftIndex=-1, rightIndex=-1;
        
        //find the index from left where the first element is in the wrong position
        for(int i=1; i<nums.Length; i++)
        {
            if(nums[i]<nums[i-1])
            {
                left=i;
                break;
            }
        }
        
        //find the index from right where the first element is in the wrong position
        for(int i=nums.Length-2; i>=0; i--)
        {
            if(nums[i]>nums[i+1])
            {
                right=i;
                break;
            }
        }
        
        if(left==0 && right==nums.Length-1)
            return 0;
        
        //Console.WriteLine($"{left}, {right}");
        
        
        leftMax=left;
        rightMin=right;

        //find the index of max element from the start
        for(int i=0; i<=right; i++)
        {
            if(nums[i]>nums[leftMax])
                leftMax=i;
        }

        //find the index of the min element from the end
        for(int i=left; i<=nums.Length-1; i++)
        {
            if(nums[i]<nums[rightMin])
                rightMin=i;
        }
        
        // Console.WriteLine($"leftMax={nums[leftMax]}");
        // Console.WriteLine($"rightmin:{nums[rightMin]}");
        // Console.WriteLine($"left:{left}, right:{right}");
        
        rightIndex=right+1;
        //find the correct position of max element from the end
        for(int i=nums.Length-1; i>right; i--)
        {
            if(nums[i]<nums[leftMax])
            {
                rightIndex=i;
                break;
            }
        }
        
        leftIndex=left-1;
        //find the correct position of min element from the start
        for(int i=0; i<left; i++)
        {
            if(nums[i]>nums[rightMin])
            {
                leftIndex=i;
                break;
            }
        }
        
        return rightIndex-leftIndex+1;
    }
}

//Time: O(N)
//Space: O(1)