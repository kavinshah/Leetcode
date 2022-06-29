"""

AB: 26^0*('B' - 'A'+1) + 26^1 =2
ZY: 26^0*('Y'-'A'+1) + 26^1*(Z-A+1)=1*25+26*26 = 25+676=

"""
class Solution:
    def titleToNumber(self, columnTitle: str) -> int:
        i=0
        total = 0
        for c in columnTitle[::-1]:
            total += 26**i * (ord(c)-ord('A')+1)
            i+=1
        return total
            