class Solution:
    def myPow(self, x: float, n: int) -> float:
        if n<0:
            x = 1/x
            n=-n
        ans = 1
        prod = x
        while(n>0):
            if n%2==1:
                ans=ans*prod
            prod=prod*prod
            n=n//2
        return ans