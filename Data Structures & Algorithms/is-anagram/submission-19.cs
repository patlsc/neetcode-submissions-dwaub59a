public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) { return false; }
        var sChars = new Dictionary<char,int>();
        var tChars = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++) {
            if (sChars.ContainsKey(s[i])) {
                sChars[s[i]]++;
            } else {
                sChars.Add(s[i],1);
            }
        }
        for (int i = 0; i < t.Length; i++) {
            if (tChars.ContainsKey(t[i])) {
                tChars[t[i]]++;
            } else {
                tChars.Add(t[i],1);
            }
        }
        if (sChars.Count != tChars.Count) { return false; }
        foreach (KeyValuePair<char,int> sc in sChars) {
            if (!tChars.ContainsKey(sc.Key) || (sChars[sc.Key] != tChars[sc.Key])) {
                return false;
            }
        }
        return true;
    }
}
