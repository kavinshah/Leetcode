/*

[1,2,3,4,5]
[1,2,5,7,9]
[1,3,4,5,8]



*/

public class Solution {
    public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3) {
        IList<int> result = new List<int>();
        int start1=0, start2=0, start3=0;
        
        while(start1<arr1.Length && start2<arr2.Length && start3<arr3.Length)
        {
            //Console.WriteLine($"{start1},{start2},{start3}");
            if(arr1[start1]==arr2[start2] && arr2[start2]==arr3[start3])
            {
                result.Add(arr1[start1]);
                start1++;
                start2++;
                start3++;
            }
            else
            {
                if(arr1[start1]>=arr2[start2] && arr1[start1]>=arr3[start3])
                {
                    if(arr1[start1]==arr2[start2])
                        start3++;
                    else if(arr1[start1]==arr3[start3])
                        start2++;
                    else
                    {
                        start2++;
                        start3++;
                    }
                }
                else if(arr2[start2]>=arr1[start1] && arr2[start2] >= arr3[start3])
                {
                    if(arr2[start2]==arr1[start1])
                        start3++;
                    else if(arr2[start2]==arr3[start3])
                        start1++;
                    else
                    {
                        start1++;
                        start3++;
                    }
                }
                else
                {
                    if(arr3[start3]==arr1[start1])
                        start2++;
                    else if(arr3[start3]==arr2[start2])
                        start1++;
                    else
                    {
                        start1++;
                        start2++;
                    }
                }
            }
        }
        
        return result;
    }
}

//time: O(N)
//space: O(1)