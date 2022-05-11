class heapelement:
    def __init__(self, data):
        self.key=data[0]
        self.val = data[1]
        
    def __lt__(self, other):
        return self.val<other.val

class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        counter=defaultdict(int)
        for n in nums:
            counter[n]+=1
        
        uniques=[]
        for key,val in counter.items():
            x = heapelement([key,val])
            heapq.heappush(uniques, x)
            if len(uniques)>k:
                heapq.heappop(uniques)
            #print(uniques)
                
        return [u.key for u in uniques]
        
 # Time: O(NlogK), Space: O(K)
 