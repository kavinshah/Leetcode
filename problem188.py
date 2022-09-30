class Solution:
    def maxProfit(self, k: int, prices: List[int]) -> int:
        min_price = [float("inf")] * (k + 1)
        max_profit = [0] * (k + 1)
        
        for j in range(len(prices)):
            for i in range(1, k + 1):
                min_price[i] = min(min_price[i], prices[j] - max_profit[i-1])
                max_profit[i] = max(max_profit[i], prices[j] - min_price[i])
