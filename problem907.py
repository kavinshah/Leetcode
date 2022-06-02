"""



"""
class Solution:
    def sumSubarrayMins(self, arr: List[int]) -> int:
        prev = []
        min_subarr = [0]*len(arr)
        
        for i in range(len(arr)):
            while(prev and arr[prev[-1]]>arr[i]):
                prev.pop()
                
            if not prev:
                min_subarr[i] = (i+1)*arr[i]
            else:
                j=prev[-1]
                min_subarr[i]=min_subarr[j] + (i-j)*arr[i]
                
            prev.append(i)
            #print(min_subarr, prev)
        return sum(min_subarr)%1000000007
        
#Time: O(N)
#Space: O(N)