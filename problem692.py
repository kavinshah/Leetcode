"""

1. keep a hashmap of all the words and their counts
2. maintain a min heap of size k based on their counts and insert the words
3. return everything in the minheap

time: O(Nlogk) -- N=total size, M=no. of unique elements, K=input k
space: O(N)




"""

class Solution:
    def topKFrequent(self, words: List[str], k: int) -> List[str]:
        counts = defaultdict(int)
        for w in words:
            counts[w]+=1
        minheap = []
        result=deque()
        for w in counts:
            if len(minheap)<k:
                heappush(minheap, [counts[w], w])
            else:
                print(w, minheap)
                if (minheap[0][0] == counts[w] and minheap[0][1] >= w) or minheap[0][0] < counts[w]:
                    heappop(minheap)
                    heappush(minheap, [counts[w], w])

        while(minheap):
            curr=heappop(minheap)
            stack = []
            while(result and result[0][0] == curr[0] and result[0][1]<curr[1]):
                stack.append(result.popleft())
            result.appendleft(curr)
            while(stack):
                result.appendleft(stack.pop())
        #print(result)
        return [r[1] for r in result]
