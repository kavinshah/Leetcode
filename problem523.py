
# 0, 0:-1
# 23, 5:1
# 25, 1: 2
# 29, 5



class Solution:
    def checkSubarraySum(self, nums: List[int], k: int) -> bool:
        modulus = {0:-1}
        currsum = 0
        for i in range(len(nums)):
            n=nums[i]
            currsum += n
            currmod = currsum%k
            #print(modulus,currsum, currmod, i)
            if currmod in modulus:
                if (i-modulus[currmod])>=2:
                    return True
            else:
                modulus[currmod]=i
            
        return False
                
        
# Time: O(N)
# Space: O(N)