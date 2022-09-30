class Solution:
    def __init__(self):
         self.cache = {}  # (k, n)  -> contain best solution for up to k transactions up to n days
​
    def maxProfit(self, k: int, prices: List[int]) -> int:
        if k <= 0:
            return 0
        n = len(prices)
        if (k, n) in self.cache:        # memoization
            return self.cache[(k, n)]   # memoization
        max_profit = 0
        for S in range(n):
            not_sell_profit = self.maxProfit(k, prices[0:S])
            # [1, 2, 3]
            #     B  ^
            #        S
            # -> [1, 2]
            sell_profit = 0
            if S >= 1:
                for B in range(S):
                    this_profit = prices[S] - prices[B]
                    subproblem_profit = self.maxProfit(k-1, prices[0:B])
                    total_profit = this_profit + subproblem_profit
                    sell_profit = max(sell_profit, total_profit)
            profit = max(not_sell_profit, sell_profit)
            max_profit = max(max_profit, profit)
        self.cache[(k, n)] = max_profit    # memoization
        return max_profit