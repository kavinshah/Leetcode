"""
[3,1,2,4]
 0 1 2 3

i=0, prev_les=[0], sum_of_ = [1*3 0 0 0]
i=1, prev_les=[1], sum_of_ = [1*3 2*1 0 0]
i=2, prev_les=[1 2], sum_of_ = [1*3 2*1 2+1*2 0]
i=3, prev_les=[1 2 3], sum_of_ = [1*3 2*1 2+1*2 4+1*4]

result = 3+2+4+8=17

[3 1 2 4]
3 1 => 1
3 1 2 =>:

[3 1 2 6 5 2 4]

explanation of sums:

the minimum of subarrays which has the current element will be:
total number of subarrays with current element as minimum [X] =(position of minimum element on left side of current element * position of minimum element on right side of currrent element)
total sum of such subarrays = current element * X

"""
class Solution:
    def sumSubarrayMins(self, arr: List[int]) -> int:
        left=[i+1 for i in range(len(arr))]
        right=[len(arr)-i for i in range(len(arr))]
        stack = []
        for i in range(len(arr)):
            #get the prev less element
            while(stack and arr[stack[-1]]>arr[i]):
                x=stack.pop()
                # use the element popped from stack and set value in right array.
                # This is because all elements in the stack greater than current element
                # must have current element as lesser on the right.
                right[x]=i-x 
            
            # set the left array for current element with topmost element in stack since this 
            # is the element which is smaller than current element
            if stack:
                left[i]=i-(stack[-1])
            else:
                left[i]=i+1
            stack.append(i)
            
        return sum(arr[i]*left[i]*right[i] for i in range(len(arr))) % 1000000007
        
        
#Time: O(N)
#Space: O(N)