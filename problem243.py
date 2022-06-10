class Solution:
    def shortestDistance(self, wordsDict: List[str], word1: str, word2: str) -> int:
        w1=[]
        w2=[]
        result=float('inf')
        for i in range(len(wordsDict)):
            if wordsDict[i]==word1:
                w1.append(i)
                if w2:
                    result=min(result, abs(i-w2[-1]))
            elif wordsDict[i]==word2:
                w2.append(i)
                if w1:
                    result=min(result, abs(i-w1[-1]))
        
        return result