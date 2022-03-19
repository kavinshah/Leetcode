class Solution:
    def pancakeSort(self, arr: List[int]) -> List[int]:
        
        def flip(index):
            nonlocal arr
            #print("flip:", index)
            for i in range((index+1)//2):
                arr[i], arr[index-i]=arr[index-i], arr[i]
        steps=[]
        for i in range(len(arr)-1, 0,-1):
            # find the index k of max element in the array 0..N-1
            maxIndex = 0
            for j in range(1, i+1):
                if arr[maxIndex]<arr[j]:
                    maxIndex=j
            
            #print(i, maxIndex)
            if maxIndex != i:
                # flip 0..k-1
                if maxIndex!=0:
                    steps.append(maxIndex+1)
                    flip(maxIndex)

                # flip 0..N-1
                steps.append(i+1)
                flip(i)
            #print(arr)
            
        return steps
            
"""
[3,2,4,1]
flip(2): [4,2,3,1]
[4,2,3,1]
flip(3): [1,3,2,4]
[1,3,2,4]
flip(2): [2,3,1,4]
[3,1,2,4]
flip(2): [2,1,3,4]
[2,1,3,4]
flip(0): [2,1,3,4]
flip(1): [1,2,3,4]
[1,2,3,4]



[3,4,2,3,2]

"""