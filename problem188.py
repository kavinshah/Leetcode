class Solution:
    def maxProfit(self, k: int, prices: List[int]) -> int:
        memo = {}
        def rec(k, i):
            if i < 0 or k <= 0:
                return 0
            if (i, k) in memo:
                return memo[(i, k)]
            res = max(rec(k, i-1),  # do not sell that day
                      max((prices[i] - prices[j] + rec(k-1, j-1) for j in range(i)), default=0))  # sell that day, buy on day j
            memo[(i, k)] = res
            return res
        return rec(k, len(prices)-1)