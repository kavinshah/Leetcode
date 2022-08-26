"""

right: cmin -> cmax, rmin=rmin+1
down : rmin -> rmax, cmax=cmax-1
left : cmax -> cmin, rmax=rmax-1
up   : rmax -> rmin, cmin=cmin+1

until rmax>=rmin and cmax>=cmin

[1, 2, 3, 4]
[5, 6, 7, 8]
[9,10,11,12]


"""

class Solution:
    def spiralOrder(self, matrix: List[List[int]]) -> List[int]:
        rmin=0
        rmax=len(matrix)-1
        cmin=0
        cmax=len(matrix[0])-1
        result=[]
        while(rmax>=rmin and cmax>=cmin):
            #right
            for i in range(cmin, cmax+1):
                result.append(matrix[rmin][i])
            rmin=rmin+1
            #print("right", result)
            
            #down
            for i in range(rmin, rmax+1):
                result.append(matrix[i][cmax])
            cmax=cmax-1
            #print("down", result)
            
            #left
            if rmax>=rmin:
                for i in range(cmax, cmin-1, -1):
                    result.append(matrix[rmax][i])
            rmax=rmax-1
            #print("left", result)
            
            #up
            if cmax>=cmin:
                for i in range(rmax, rmin-1, -1):
                    result.append(matrix[i][cmin])
            cmin=cmin+1
            #print("up", result)
            
            #print(rmin,rmax,cmin,cmax)
                
        return result
        
#time: O(MN)
#space: O(1)