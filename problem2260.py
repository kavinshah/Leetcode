"""



"""

class Solution:
    def minimumCardPickup(self, cards: List[int]) -> int:
        diff = -1
        pair = {}
        minpair = float('inf')
        for i in range(len(cards)):
            if cards[i] not in pair:
                pair[cards[i]] = [i]
                
            elif len(pair[cards[i]]) == 1:
                pair[cards[i]].append(i)
                minpair = min(minpair, (pair[cards[i]][1] - pair[cards[i]][0] + 1))
            else:
                currpair = pair[cards[i]]
                if (i-currpair[1]) < (currpair[1]-currpair[0]):
                    pair[cards[i]]=[currpair[1], i]
                    minpair = min(minpair, (pair[cards[i]][1] - pair[cards[i]][0] + 1))
                    
        if minpair==float('inf'):
            return -1
        return minpair