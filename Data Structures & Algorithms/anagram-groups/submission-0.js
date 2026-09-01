class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        let res = {}

        for(let str of strs){
            let sSort = str.split("").sort().join("")
            if(!res[sSort]) res[sSort] = []
            res[sSort].push(str)
        }
        return Object.values(res)
    }
}

