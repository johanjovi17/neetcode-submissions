class Solution {
    /**
     * @param {string} s
     * @param {number} k
     * @return {number}
     */
    characterReplacement(s, k) {
        let res=0
        let mySet = new Set(s)

        for(let c of mySet){
            let count=0,l=0
            for(let r=0;r<s.length;r++){
                if(c===s[r]) count++

                while(r-l+1-count>k){
                    if(s[l]===c) count--
                    l++
                }

                res=Math.max(res,r-l+1)
            }
        }
        return res
    }
}
