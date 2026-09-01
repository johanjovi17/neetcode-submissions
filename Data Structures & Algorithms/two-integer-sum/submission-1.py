class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        mp = {}

        for i, num in enumerate(nums):
            compliment = target - num

            if compliment in mp:
                return [mp[compliment], i]
            
            mp[num] = i
        return False