class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs) {
        if(strs.length===0) return ""
        let res = "", sizes = []

        for(let s of strs){
            sizes.push(s.length)
        }

        for(let sz of sizes){
            res += sz + ","
        }

        res += "#"

        for(let str of strs){
            res += str
        }

        return res

    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str) {
        if(str.length===0) return []
        let i=0,res=[],sizes=[]
    while(str[i]!=='#'){
        let cur = ''
        while(str[i]!==','){
            cur+= str[i]
            i++
        }
        sizes.push(parseInt(cur))
        i++
    }
     i++

     for(let sz of sizes){
        res.push(str.slice(i,i+sz))
        i+=sz
     }
return res


    }

}
