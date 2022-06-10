class Solution:
    def calculateTime(self, keyboard: str, word: str) -> int:
        charmap = {}
        result=0
        prevpos=0
        for i in range(len(keyboard)):
            charmap[keyboard[i]]=i
        #print(charmap)
        
        for ch in word:
            result+=abs(charmap[ch]-prevpos)
            prevpos=charmap[ch]
            #print(ch, result, prevpos)
            
        return result