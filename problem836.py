/**
https://leetcode.com/problems/rectangle-overlap/
 * @param {number[]} rec1
 * @param {number[]} rec2
 * @return {boolean}
 */
// var isRectangleOverlap = function(rec1, rec2) {
//   let rec1x1, rec1x2, rec1y1, rec1y2;
//   let rec2x1, rec2x2, rec2y1, rec2y2;

//   [rec1x1, rec1y1, rec1x2, rec1y2] = rec1;
//   [rec2x1, rec2y1, rec2x2, rec2y2] = rec2;

//   let smallx1, smallx2, largex1, largex2;
//   let smally1, smally2, largey1, largey2;

//   if (rec1x1 < rec2x1) {
//     smallx1 = rec1x1;
//     smallx2 = rec1x2;
//     largex1 = rec2x1;
//     largex2 = rec2x2;
//   } else {
//     largex1 = rec1x1;
//     largex2 = rec1x2;
//     smallx1 = rec2x1;
//     smallx2 = rec2x2;
//   }

//   if (rec1y1 < rec2y1) {
//     smally1 = rec1y1;
//     smally2 = rec1y2;
//     largey1 = rec2y1;
//     largey2 = rec2y2;
//   } else {
//     largey1 = rec1y1;
//     largey2 = rec1y2;
//     smally1 = rec2y1;
//     smally2 = rec2y2;
//   }

//   if (smallx2 > largex1 && smally2 > largey1) {
//     return true;
//   }
  
//   return false;
// };

var isRectangleOverlap = function(rec1, rec2) {
  let rec1x1, rec1x2, rec1y1, rec1y2;
  let rec2x1, rec2x2, rec2y1, rec2y2;

  [rec1x1, rec1y1, rec1x2, rec1y2] = rec1;
  [rec2x1, rec2y1, rec2x2, rec2y2] = rec2;

  if (rec1x1 < rec2x1) {
    if (rec1x2 <= rec2x1) {
      return false;
    }
  } else {
    if (rec2x2 <= rec1x1) {
      return false;
    }
  }
  if (rec1y1 < rec2y1) {
    if (rec1y2 <= rec2y1) {
      return false;
    }
  } else {
    if (rec2y2 <= rec1y1) {
      return false;
    }
  }

  return true;
};


/*

- for overlap to exist: 
  - after choosing smaller x1, its corresponding x2 must be greater than 
    x1 of the other rectangle 
  - after choosing smaller y1, its corresponding y2 must be greater than 
    y1 of the other rectangle 


Example 1:
               x y x y           x y x y
Input: rec1 = [0,0,2,2], rec2 = [1,1,3,3]
Output: true


Example 2:
               x y x y           x y x y
Input: rec1 = [0,0,1,1], rec2 = [1,0,2,1]
Output: false


Example 3:
               x y x y           x y x y
Input: rec1 = [0,0,1,1], rec2 = [2,2,3,3]
Output: false

No overlap: 