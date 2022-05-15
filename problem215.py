"""

arr = [ 10, 4, 5, 8, 6, 11, 26 ]
        0   1  2  3  4   5   6

k=3

l=0
r=6
k=3
x = 26

j=0, i=0, [ 10, 4, 5, 8, 6, 11, 26 ]
j=1, i=1, [ 10, 4, 5, 8, 6, 11, 26 ]
j=2, i=2, [ 10, 4, 5, 8, 6, 11, 26 ]
j=3, i=3, [ 10, 4, 5, 8, 6, 11, 26 ]
j=4, i=4, [ 10, 4, 5, 8, 6, 11, 26 ]
j=5, i=5, [ 10, 4, 5, 8, 6, 11, 26 ]
i=6
return 6


---------------------------------------
partition(0,5,3)

l=0
r=5
arr=[ 10, 4, 5, 8, 6, 11]
x=arr[5]=11

j=0, i=0, [ 10, 4, 5, 8, 6, 11]
j=1, i=1, [ 10, 4, 5, 8, 6, 11]
j=2, i=2, [ 10, 4, 5, 8, 6, 11]
j=3, i=3, [ 10, 4, 5, 8, 6, 11]
j=4, i=4, [ 10, 4, 5, 8, 6, 11]
i=5

return 5

--------------------------------------
partition(arr, 0, 4)
l=0
r=4
arr=[10, 4, 5, 8, 6]
x=6

j=0, i=0, [10, 4, 5, 8, 6]
j=1, i=0, [4, 10, 5, 8, 6]
j=2, i=1, [4, 5, 10, 8, 6]
j=3, i=2, [4, 5, 10, 8, 6]
[4, 5, 6, 8, 10]
return 2

nums = [10, 4, 5, 8, 6, 11, 26]
element = findKthLargest(nums, 3)
print(element)
nums = [10, 4, 8, 5, 26, 11, 6]
element = findKthLargest(nums, 1)
print(element)
nums = [10, 4, 8, 5, 26, 11, 6]
element = findKthLargest(nums, 5)
print(element)
nums = [10, 4, 8, 5, 26, 11, 6]
element = findKthLargest(nums, 7)
print(element)
nums = [10, 4, 8, 5, 26, 11, 6]
element = findKthLargest(nums, 6)
print(element)
--------------------------------------
"""
class Solution:
    def findKthLargest(self, nums, k):
        k=len(nums)-k+1
        def partition(low, high, pivotindex):
            nonlocal nums
            nums[high], nums[pivotindex]=nums[pivotindex], nums[high]
            j=low
            for i in range(low, high):
                if nums[i] < nums[high]:
                    nums[i], nums[j] = nums[j], nums[i]
                    j+=1
            nums[j], nums[high]=nums[high], nums[j]
            return j
            
        def quickselect(low, high):
            nonlocal nums, k
            if low==high:
                return nums[low]
            pivot = partition(low, high, random.randint(low, high))
            if pivot==(k-1):
                return nums[pivot]
            if pivot > (k-1):
                return quickselect(low, pivot-1)
            else:
                return quickselect(pivot+1, high)
        return quickselect(0, len(nums)-1)
        
        
        



