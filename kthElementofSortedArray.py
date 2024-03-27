https://www.geeksforgeeks.org/problems/k-th-element-of-two-sorted-array1317/1
https://replit.com/@KavinShah6/CheapHungrySweepsoftware#main.py

def kthElement(arr1, arr2, n, m, k):
  index1=-1
  index2=-1
  
  if(arr1[index1+1]<=arr2[index2+1]):
      index1=0
  else:
      index2=0
  
  while(index1<n and index2<m):
      #print(index1, index2)
      if((index1+index2+2) == k):
          if(index1==-1):
              return arr2[index2]
          if(index2 == -1):
              return arr1[index1]

          if(arr1[index1] <= arr2[index2]):
              return arr2[index2]
          else:
              return arr1[index1]
  
      if(index1+1 == n):
          index2+=1
      elif(index2+1 == m):
          index1+=1
      elif(arr1[index1+1] <= arr2[index2+1]):
          index1+=1
      else:
          index2+=1
  return -1

#print(kthElement([4,5,6,12], [4,5,6,8,8], 4, 5, 9))
arr1="43 46 49 49 50 52 53 55 57 57 60 63 64 69 69 71 71 80 83 84 84 88 90 95 95 98 98 100 100 107 112 113 114 116 117 117 121 121 122 124 126 127 128 128 133 134 136 137 137 139 140 142 143 146 146 146 149 150 152 152 155 155 156 162 163 164 172 180 183 183 191 192 194 195 199 200 211 213 215 218 220 223 224 226 228 230 232 236 240 248 251 254 255 256 256 259 260 262 268 269 273 275 278 278 282 283 286 286 286 294 294 294 295 295 296 297 298 300 308 309 309 309 310 312 315 323 328 330 330 332 333 337 338 343 343 345 348 352 354 355 358 358 361 361 368 370 372 377 381 385 390 392 393 398 401 401 403 407 408 408 414 415 418 421 422 426 431 432 433 434 437 437 439 441 441 445 446 447 449 449 449 450 450 452 453 456 460 462 465 465 468 469 473 476 477 477 485 485 488 489 492 495 496 497 499 501 501 501 503 504 505 509 511 518 526 527 527 531 533 534 537 537 541 545 548 550 552 552 555 556 558 560 562 563 564 569 571 574 576 577 579 584 586 589 589 598 598 599 600 603 608 608 615 620 620 624 625 627 629 630 631 632 634 635 639 644 645 646 647 652 653 658 659 664 668 670 672 675 683 684 687 688 696 696 698 702 707 715 720 721 730 733 736 743 747 749 759 759 761 761 763 766 766 769 770 773 777 779 779 781 782 782 796 807 808 808 811 811 812 812 817 820 822 822 823 824 827 832 832 835 836 836 839 845 853 854 856 860 862 864 868 870 877 877 884 889 890 891 892 899 918 919 921 926 927 930 931 932 932 934 934 939 939 939 940 940 940 942 946 947 949 951 954 958 959 961 962 969 970 973 974 978 981 982 984 984 986 986 988 988 990 992 996 996 1007 1007 1008 1014 1014 1016 1024 1025 1026 1035 1039"
arr2="44 45 47 50 50 51 58 60 62 62 62 68 70 70 71 71 74 74 77 79 79 81 82 82 90 91 91 92 96 101 103 104 108 110 112 113 113 115 115 116 117 117 120 121 122 124 126 128 130 132 132 133 136 138 138 143 147 148 154 155 155 156 158 161 163 165 166 168 168 170 171 173 178 182 183 185 185 186 187 190 190 191 191 195 198 200 201 207 207 208 209 219 221 222 223 226 227 228 229 230 233 236 238 239 240 242 242 246 249 255 256 256 258 259 263 264 265 267 267 268 270 273 274 274 284 285 285 288 288 290 295 299 299 303 304 309 309 310 313 316 318 318 319 321 323 325 327 328 329 329 329 336 336 341 341 342 342 343 346 346 350 350 350 352 352 353 358 359 360 364 365 370 371 375 382 383 384 395 403 404 408 408 409 410 410 411 419 420 421 422 424 426 430 431 431 441 442 444 449 450 451 452 457 462 463 463 463 471 471 472 475 475 476 478 480 483 487 487 490 493 493 493 494 495 496 497 500 503 504 505 509 513 514 521 522 531 532 538 539 541 541 541 543 544 546 547 549 550 556 558 560 563 563 565 565 566 569 571 575 579 580 585 588 589 589 591 591 592 593 598 598 599 600 604 607 608 609 611 612 614 617 618 624 624 630 631 632 638 641 642 645 645 646 652 653 658 660 663 663 666 668 670 674 675 676 678 678 686 688 690 694 695 696 699 700 700 701 703 703 704 704 705 711 712 714 714 720 728 728 731 734 735 738 742 743 744 745 745 746 747 748 751 754 757 760 761 763 764 765 766 767 768 768 775 775 776 777 779 781 781 781 783 787 787 789 790 792 796 796 801 804 805 810 810 814 821 826 830 834 839 839 840 847 849 851 853 853 856 857 859 859 861 861 863 865 865 867 867 868 868 869 874 875 879 880 881 882 885 896 896 896 900 906 906 908 915 917 917 922 926 926 927 931 933 939 941 941 943 945 946 946 949 951 955 955 956 957 963 967 968 969 972 974 974 981 983 984 984 985 987 988 989 989 990 992 996 996 996 997 997 998 1002 1002 1003 1006 1006 1008 1010 1016 1016 1018 1019 1020 1021 1022 1026 1027 1032 1032 1033 1034 1034 1038"
print(kthElement(arr1.split(" "), arr2.split(" "), len(arr1.split(" ")), len(arr2.split(" ")), 888))

#time: O(N+M)
#space: O(1)


#todo in time : log (M+N)

/*

[6,7,8,9,10]
[1,2,3,4,5]

5



*/