"""

[1,0] -> 0 before 1

0->1
1->2
2->3
3->0

0->1->2->3
-
|     -
|    /
|   /
|  /
| /
4


                         4<---- 0 ----> 1
                                ^       |
                                |       |
                                |       |
                                |       |
                                |       v
                                3<----- 2

0->1
1->0

"""
class Solution:
    def canFinish(self, numCourses: int, prerequisites: List[List[int]]) -> bool:
        
        def Traverse(node):
            nonlocal courses, currentpath, visited
            #print(node, currentpath, visited)
            for neighbour in courses[node]:
                if neighbour in currentpath:
                    return False
                if neighbour not in visited:
                    visited.add(neighbour)
                    currentpath.add(neighbour)
                    if not Traverse(neighbour):
                        return False
                    currentpath.remove(neighbour)
            return True
                 
        courses = defaultdict(set)
        currentpath = set()
        visited= set()
        for i in range(numCourses):
            courses[i]
            
        for p in prerequisites:
            courses[p[1]].add(p[0])
        
        #print(courses, courses.keys())
        
        for c in courses.keys():
            if c not in visited:
                visited.add(c)
                currentpath.add(c)
                if not Traverse(c):
                    return False
                currentpath.remove(c)
                
        return True   
        