class Solution:
    def totalFruit(self, fruits: List[int]) -> int:
        hashmap = {}
        i=0
        j=0
        maxLen = 0
        while(i<=j and j<len(fruits)):
            if fruits[j] in hashmap or len(hashmap)<2:
                if fruits[j] not in hashmap:
                    hashmap[fruits[j]]=0
                hashmap[fruits[j]]+=1
                maxLen=max(maxLen, j-i+1)
                j+=1
            else:
                while(True):
                    hashmap[fruits[i]]-=1
                    i+=1
                    if hashmap[fruits[i-1]]==0:
                        break
                    
                del hashmap[fruits[i-1]]
                
            #print(hashmap,len(hashmap), maxLen, i, j)
        return maxLen