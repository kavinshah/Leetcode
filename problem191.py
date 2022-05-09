"""

3

3/2 ==> 1 , remainder = 1
1/2 ==> 0 , remainder = 1

15
15/2 = 7 , remainder = 1
7/2 = 3 , remain = 1
3/2 = 1 , reamin = 1
1/2 = 0 , reamin = 1

Dont use divide operation. Use bitwise right shift operation.
Don't use modulus operation to get last bit. Instead use &1 to get the last bit.



"""

class Solution:
    def hammingWeight(self, n: int) -> int:
        
        count = 0
        while(n):
            count+=n&1
            n=n>>1
        # while(n!=0):
        #     count += n%2
        #     n=n//2
        
        return count