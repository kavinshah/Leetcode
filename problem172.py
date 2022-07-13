"""

n!=n*n-1*n-2....3*2*1
10 ==> 5*2

brute force:
powerfive = {25:2,125:3,625:4,3125:5}
powertwo = {4:2,8:3,16:4,32:5,64:6,128:7,256:8,512:9,1024:10,2048:11,4096:12,8192:13}
factorten=0
factorfive=0
factortwo=0
i = 1 to n:
    if i in poweroffive:
        factorfive+=poweroffive[i]
    else i in poweroftwo:
        factortwo+=poweroffive[i]
    else if n%10==0:
        factorten+=1
    else if n%5==0:
        factorfive+=1
    else if n%2==0:
        factortwo+=1

result=factorten+min(factorfive,factortwo)

33,34,35,36,37,38,39,40

factorten=3
factorfive=5
factortwo=26

"""

class Solution:
    def trailingZeroes(self, n: int) -> int:
        # powerfive = {5:1,25:2,125:3,625:4,3125:5}
        # powertwo = {2:1, 4:2,8:3,16:4,32:5,64:6,128:7,256:8,512:9,1024:10,2048:11,4096:12,8192:13}
        #powerten = {10:1,100:2,1000:3,10000:4,100000:5}
        factorten=0
        factorfive=0
        factortwo=0
        for counter in range(1,n+1):
            i=counter
            while(i%10==0):
                factorten+=1
                i=i//10
                
            while(i%5==0):
                factorfive+=1
                i=i//5
        #print(factorten, factorfive, factortwo)
        return factorten+factorfive
        