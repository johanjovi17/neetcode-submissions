public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = new Dictionary<string,List<string>>();
        foreach(var w in strs){
            int[] count = new int[26];
            foreach(var c in w){
                count[c-'a']++;
            }
            var key = string.Join(',',count);
            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            res[key].Add(w);
        }
        return res.Values.ToList<List<string>>();
    }
}
