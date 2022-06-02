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


"""
class Solution:
    def sumSubarrayMins(self, arr):
        
        prev_lesser = []   # optimization for finding minimum
        sum_of_minima_up_to = [0] * len(arr)
        
        for i in range(len(arr)):
            
            # find j: "closest" element that is smaller than arr[i]
            while len(prev_lesser) > 0 and arr[prev_lesser[-1]] > arr[i]:
                prev_lesser.pop()
            
            if len(prev_lesser) == 0:
                # arr[i] is lesser than anything to its left.
                # hence, all sub-arrays up to index i will have arr[i] as their minimum.
                # there are i+1 such sub-arrays, hence the sum is (i+1)*arr[i].
                sum_of_minima_up_to[i] = (i+1) * arr[i]
            else:
                # for some j (top of stack) we have arr[j] is less than arr[i].
                # all the sub-arrays that include j will have the same minimum sum as sum_of_minima_up_to[j].
                # all of the sub-arrays that do not include j (to the "right" of j) will have arr[i] as their
                # minimum, and there are (i-j) such arrays.
                j = prev_lesser[-1]
                sum_of_minima_up_to[i] = sum_of_minima_up_to[j] + (i-j) * arr[i]
            
            # stack remains non-decreasing since we popped all the larger elements on lines 10-11
            prev_lesser.append(i)
        
        return sum(sum_of_minima_up_to) % (10**9 + 7)
        
#Time: O(N)
#Space: O(N)