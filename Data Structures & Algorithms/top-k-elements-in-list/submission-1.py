from collections import Counter

class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = Counter(nums)

        sortedItems = sorted(
            count.items(),
            key=lambda x: x[1],
            reverse=True
        )

        res=[]

        for num, freq in sortedItems[:k]:
            res.append(num)
        return res