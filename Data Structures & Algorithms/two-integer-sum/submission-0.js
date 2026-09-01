class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        let myMap = new Map()
        for(let i=0;i<nums.length;i++){
            let compliment = target - nums[i]
            if(myMap.has(compliment)){
                return [myMap.get(compliment),i]
            }
            myMap.set(nums[i],i) 
        }
        return null
    }
}
