"""

-> traverse in reverse order until you hit a whitespapce to get all the domains d1.d2.d3 and d1.d2
-> everythings before the whitespace is the count
-> increase the counts by number for each domain found in previous step
-> return the result in value<space>key

Time: O(NK) --k is length of each domain, N=no. of domains
Space: O(Nk)

"""
from collections import deque, defaultdict
class Solution:
    def subdomainVisits(self, cpdomains: List[str]) -> List[str]:
        counts = defaultdict(int)
        for x in cpdomains:
            i=0
            curr=deque()
            currcount = 0
            while(x[i] != ' '):
                i+=1
            currcount = int(x[:i])
            for j in range(len(x)-1,i,-1):
                if x[j]=='.':
                    counts[''.join(curr)]+=currcount
                curr.appendleft(x[j])
            counts[''.join(curr)]+=currcount

        #print(counts)
        return [f"{value} {key}" for key,value in counts.items()]

