class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        map = {}

        for i,num in enumerate(nums):
            compliment = target - num
            if compliment in map:
                return [map[compliment],i]
            map[num]=i 