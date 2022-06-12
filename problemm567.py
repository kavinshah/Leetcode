"""

len1=11 [10]
len2=5 [4]

11-5=6


"""
class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        if len(s1)>len(s2):
            return False
        count1 = [0]*26
        count2=[0]*26
        check=0
        
        for i in range(len(s1)):
            count1[ord(s1[i])-ord('a')]+=1
            count2[ord(s2[i])-ord('a')]+=1
        
        for i in range(26):
            if count1[i]==count2[i]:
                check+=1
        
        for i in range(1, len(s2)-len(s1)+1):
            prevchar = ord(s2[i-1])-ord('a')
            currchar = ord(s2[i+len(s1)-1])-ord('a')
            if check==26:
                return True
            
            count2[currchar]+=1
            if count2[currchar]==count1[currchar]:
                check+=1
            elif count2[currchar]==count1[currchar]+1: # reduce check count if previous count for right index character was equal
                check-=1
                
            count2[prevchar]-=1
            if count2[prevchar]==count1[prevchar]:
                check+=1
            elif count2[prevchar]+1==count1[prevchar]: # reduce check count if previous count for left index character was equal
                check-=1
            
        return check==26
            
        