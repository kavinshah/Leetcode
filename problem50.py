class Solution:
    def myPow(self, x: float, n: int) -> float:
        cache = {0:1}
        
        def calculatePow(n):
            nonlocal cache, x
            
            if n in cache:
                return cache[n]
            
            if not n%2:
                cache[n] = calculatePow(n/2) * calculatePow(n/2)
            else:
                cache[n] = calculatePow(n//2) * calculatePow(n//2) * x
        
            return cache[n]
        
        cache[1]=x
        if n>0:
            calculatePow(n)
            return cache[n]
        else:
            calculatePow(-n)
            return 1/cache[-n]