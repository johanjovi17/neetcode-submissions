class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums) {
        let mySet = new Set(nums)
        let longest = 0

        for(let num of mySet){
            if(!mySet.has(num - 1)) //check to see if you're at the start of a sequence
            {
                let length = 1
                while(mySet.has(num + length)){
                    length++
                }
                longest = Math.max(longest,length)
            }
        }
        return longest
    }
}
