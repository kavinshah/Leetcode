"""

1. keep a hashmap of all the words and their counts
2. maintain a min heap of size k based on their counts and insert the words
3. return everything in the minheap

time: O(Nlogk) -- N=total size, M=no. of unique elements, K=input k
space: O(N)




"""

"""

1. keep a hashmap of all the words and their counts
2. maintain a min heap of size k based on their counts and insert the words
3. return everything in the minheap

time: O(Nlogk) -- N=total size, M=no. of unique elements, K=input k
space: O(N)

leetcode solution:
Complexity Analysis
Let NN
 be the length of words.
Time Complexity: O(N)O(N)
. We take O(N)O(N)
 time to count frequencies and enumerate all buckets. Since we only need to get kk
 words from tries, we traverse kk
 paths in tries, and each path is neglectable in length (≤10≤10
), O(k)O(k)
 time is required to generate all those words from tries. Besides, it takes O(N)O(N)
 time to put NN
 words in tries. As k≤Nk≤N
, O(N+k)=O(N)O(N+k)=O(N)
Space Complexity: O(N)O(N)
, like other approaches, our counter cnt needs O(N)O(N)
 space. Besides, tries to store at most NN
 words also need O(n)O(n)
 space.
Note: Though we optimize the time complexity to O(N)O(N)
, it may runs slower than previous approaches due to the large constant factors.

"""

from collections import Counter


class Solution:
    def topKFrequent(self, words: List[str], k: int) -> List[str]:
        n = len(words)
        cnt = Counter(words)
        bucket = [{} for _ in range(n+1)]
        self.k = k

        def add_word(trie: Mapping, word: str) -> None:
            root = trie
            for c in word:
                if c not in root:
                    root[c] = {}
                root = root[c]
            root['#'] = {}

        def get_words(trie: Mapping, prefix: str) -> List[str]:
            if self.k == 0:
                return []
            res = []
            if '#' in trie:
                self.k -= 1
                res.append(prefix)
            for i in range(26):
                c = chr(ord('a') + i)
                if c in trie:
                    res += get_words(trie[c], prefix+c)
            return res

        for word, freq in cnt.items():
            add_word(bucket[freq], word)

        res = []
        for i in range(n, 0, -1):
            if self.k == 0:
                return res
            if bucket[i]:
                res += get_words(bucket[i], '')
        return res