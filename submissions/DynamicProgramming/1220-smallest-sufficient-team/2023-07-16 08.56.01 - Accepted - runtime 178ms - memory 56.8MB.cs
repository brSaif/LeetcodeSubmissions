public class Solution {
    public int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people) {
      Dictionary<string, int> bitMaskKey = BuildBitMask(req_skills);
        Dictionary<int, List<int>> skillSets = new Dictionary<int, List<int>>();
        skillSets[0] = new List<int>();
        for (int i = 0, bitmask, newBitmask; i < people.Count; ++i) {
            bitmask = ConvertPersonToBitMask(bitMaskKey, people[i]);
            foreach (int key in skillSets.Keys.ToArray()) {
                if ((key & bitmask) != bitmask) {
                    newBitmask = (key | bitmask);
                    if (!skillSets.ContainsKey(newBitmask) || (skillSets[newBitmask].Count > (skillSets[key].Count + 1))) {
                        skillSets[newBitmask] = new List<int> (skillSets[key]);
                        skillSets[newBitmask].Add(i);
                    }
                }
            }
        }
        return skillSets[ConvertPersonToBitMask(bitMaskKey, req_skills)].ToArray();
    }

    private Dictionary<string, int> BuildBitMask(string[] req_skills) {
        Dictionary<string, int> bitMaskKey = new Dictionary<string, int>();
        int val = 1;
        foreach (string skill in req_skills) {
            bitMaskKey.Add(skill, val);
            val *= 2;
        }
        return bitMaskKey;
    }

    private int ConvertPersonToBitMask(Dictionary<string, int> bitMaskKey, IEnumerable<string> person) {
        int bitmask = 0;
        foreach (string skill in person) {
            bitmask += bitMaskKey[skill];
        }
        return bitmask;
    }
}