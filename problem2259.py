"""

1231, 1 => 231

2132, 2 => 213

21232, 2 => 2132 (2132,1232,2123)

2121212, 2 => 212121 (212121,212112,211212,121212)

2222, 2 => 222

23232323=> 3232323

21213,2 => 2113

23251, 2 => 3251 (3251,2351)



"""
class Solution:
    def removeDigit(self, number: str, digit: str) -> str:
        result=[]
        index = -1
        
        for i in range(len(number)):
            if ord(number[i])==ord(digit):
                index = i
                if i<len(number)-1 and ord(number[i])<ord(number[i+1]):
                    break
            
        #print(index, number[0:i])
        result= number[0:index] + number[index+1:]
        return str(result)