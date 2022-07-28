"""

                                abcd, pabsd
                            /                       \
                        bcd,bsd                     abcd,bsd
                       /        \                   /           \
                    cd,sd       cd,bsd          cd,sd             bcd,sd
                    /   \       /    \          /      \            /       \
                '',''     d,"" '','' d,''    '',''     bcd,sd     d,d      d,''
                             /   \                      /   \      /   \ 
                            '',''  d,''                 d,d  d,'' d,'' '',''
                                                       /    \
                                                     d,'' '',''

abcde, ace
ace, abcde
i=0, j=0, result=1
i=1, j=1, result=1
i=1, j=2, result=2
i=2, j=3, result=2
i=2, j=4, result=3
i=3, j=5
ace, abcde
    a   c   e
a   
b
c
d
e           1


                            abc, def
                            /         \
                        
i=0, j=0, current=0
i=1, j=0, current=0
i=2, j=0, current=0
i=3, return 0


                            acef, abccdef
                            /           \
                        
i=0, j=0, current=4
i=1, j=0, current=4
i=2, j=0, current=4
i=3, j=0, current=4

                            psnw, vozsh
                        /               \
                        
i=0, j=0, result=0
i=1, j=0, result=1
i=2, j=0, result=1
i=3, j=0, result=1

                                                psnw, vozsh
                        /                                                       \
                snw, vozsh                                                      psnw, ozsh
                /           \
        nw, vozsh           snw, ozsh
        /           \           
    w, vozsh        nw, vozsh
    /       \        /       \
"", vozsh w,ozsh    w,vozsh   nw,ozsh
|        /      \     /     \         /         \
0     "",zsh    w,zsh '',vozsh w,ozsh w,ozsh    nw,zsh
        |       /   \     |      |    /   \     /   \
        0    '',zsh w,sh  0      0   0  w,zsh  0     0
                |   /   \
                0 '',sh  w,h
                    |    /  \
                    0  "",h w,""
                        |    |
                        0    0
i=0, j=0

if i> len(text1) or j>len(text2):
    return 0
else if text1[i]==text2[j]:
    1+find(i+1,j+1)
else:
    max(find(i,j+1), find(i+1,j))


bottom up (tabulation) -


    g   t   g   t   g   a   t   c   g
a   5   5   5   5   4   3   2   2   1   0
c   5   5   5   5   4   3   2   2   1   0
t   5   5   5   5   4   3   2   1   1   0
g   5   4   4   4   4   3   2   1   1   0
a   4   4   3   3   3   3   2   1   1   0
t   4   4   3   3   2   2   2   1   1   0
t   3   3   3   3   2   2   2   1   1   0
a   2   2   2   2   2   2   1   1   1   0
g   1   1   1   1   1   1   1   1   1   0
    0   0   0   0   0   0   0   0   0   0


"""
class Solution:
    def longestCommonSubsequence(self, text1: str, text2: str) -> int:
        result = [[0]*(len(text1)+1) for i in range(2)]
        #print(f'row: {len(result)}, cols: {len(result[0])}')
        for i in range(len(text2)-1,-1,-1):
            result[0]=[0]*(len(text1)+1)
            for j in range(len(text1)-1,-1,-1):
                if ord(text1[j])==ord(text2[i]):
                    result[0][j]=1+result[1][j+1]
                else:
                    result[0][j]=max(result[1][j], result[0][j+1])
            result[1]=result[0].copy()
                #print(i,j, result[i][j])
        return result[1][0]