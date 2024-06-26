"""

[1,3,1,2]

left = [1 2 3 4], right = [4 3 2 1], stack = []

left = [1 1 2 1], right = [4 1 2 1], stack = []



"""
class Solution:
    def totalStrength(self, arr: List[int]) -> int:
        n = len(arr)
        m = 1000000007
        
        next_smaller_element = [-1]*n      #monotonic inc stack, left to right
        prev_smaller_element = [-1]*n      #monotonic inc stack, right to left
    
        stack1 = []
        for i in range(n):
            while len(stack1) and arr[stack1[-1]] > arr[i]:
                next_smaller_element[stack1[-1]] = i
                stack1.pop()   
            stack1.append(i)

            
        stack2 = []
        for i in range(n-1,-1,-1):
            while len(stack2) and arr[stack2[-1]] >= arr[i]:
                prev_smaller_element[stack2[-1]] = i
                stack2.pop()
            stack2.append(i)

            
        pref = [0]*(n)
        pref[0] = arr[0]
        for i in range(1 , n):
            pref[i] = (pref[i-1]%m+arr[i]%m)%m
        
#         print(prev_smaller_element)
#         print(next_smaller_element)
        
        # pref of pref
        
        prepref = [0]*(n+2)
        for i in range(n):
            prepref[i+1] = (prepref[i]%m +pref[i]%m)%m
 
        ans = 0
        for i in range(n):
            if prev_smaller_element[i]== -1:
                left = 0
            else:
                left = prev_smaller_element[i]+1
                
            if next_smaller_element[i]== -1:
                right = n-1
            else:
                right = next_smaller_element[i]- 1

            ans = ans + arr[i] * ((prepref[right+1] - prepref[i])*(i- left+1) - (prepref[i]-prepref[left-1])*(right-i+1))
            ans = ans %m
    
        
        
        return ans%m
                
        