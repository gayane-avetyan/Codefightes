using System.Linq;

namespace Intro
{
    class AllLongestStrings
    {
        string[] allLongestStrings(string[] inputArray)
        {
            int max = inputArray.Max(i => i.Length);
            return inputArray.Where(i => i.Length == max).ToArray();
        }
    }
}
