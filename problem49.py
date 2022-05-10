class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        result = defaultdict(list)
        
        def getchararr(string):
            char=[0]*26
            for s in string:
                char[ord(s)-ord('a')]+=1    
            return tuple(char)
        
        for s in strs:
            chararr = getchararr(s)
            result[chararr].append(s)
            
        return result.values()
        
# Time: O(NK), Space: O(NK)