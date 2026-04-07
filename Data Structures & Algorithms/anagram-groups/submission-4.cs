public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> anagramHashGroup = new Dictionary<string,List<string>>();
        for (int i = 0; i < strs.Length; i++) {
            //figure out which existing anagram group this goes into and add it
            string anagramHash = GetStringAnagramHash(strs[i]);
            if (anagramHashGroup.ContainsKey(anagramHash)) {
                anagramHashGroup[anagramHash].Add(strs[i]);
            } else {
                anagramHashGroup.Add(anagramHash,new List<string>{strs[i]});
            }
        }
        return anagramHashGroup.Values.ToList();
    }

    static char[] alphabet = new char[]{
    'a','b','c','d','e','f','g','h','i','j','k','l','m',
    'n','o','p','q','r','s','t','u','v','w','x','y','z'
};

    string GetStringAnagramHash(string s) {
        Dictionary<char,int> freqs = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++) {
            if (freqs.ContainsKey(s[i])) {
                freqs[s[i]]++;
            } else {
                freqs.Add(s[i],1);
            }
        }
        string r = "";
        for (int i = 0; i < alphabet.Length; i++) {
            r += (freqs.ContainsKey(alphabet[i]) ? freqs[alphabet[i]] : "0") + "/";
        }
        return r;
    }
}
