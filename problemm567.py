"""

len1=11 [10]
len2=5 [4]

11-5=6


"""
class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        def checkcounts(c1, c2):
            for i in range(26):
                if c1[i]!=c2[i]:
                    return False
            return True
            
        if len(s1)>len(s2):
            return False
        count1 = [0]*26
        count2=[0]*26
        for i in range(len(s1)):
            count1[ord(s1[i])-ord('a')]+=1
            count2[ord(s2[i])-ord('a')]+=1
        if checkcounts(count1, count2):
            return True
        for i in range(1, len(s2)-len(s1)+1):
            count2[ord(s2[i-1])-ord('a')]-=1
            count2[ord(s2[i+len(s1)-1])-ord('a')]+=1
            if checkcounts(count1, count2):
                return True
        
            
        return False
            
        