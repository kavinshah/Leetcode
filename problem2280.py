class Solution:
    def minimumLines(self, stockPrices: List[List[int]]) -> int:
        stockPrices = sorted(stockPrices, key=lambda x : x[0])
        #print(stockPrices)
        diffX = None
        diffY = None
        count = 0
        for i in range(1, len(stockPrices)):
            currX = (stockPrices[i][0]-stockPrices[i-1][0])
            currY = (stockPrices[i][1]-stockPrices[i-1][1])
            if diffX==None or diffY==None or currY*diffX != diffY*currX:
                count+=1
                diffX=currX
                diffY=currY
                print(currX, currY, currY*diffX, diffY*currX)
                #print(i, count)
        return count
            
# Time: O(NlogN),
# Space: O(N)
