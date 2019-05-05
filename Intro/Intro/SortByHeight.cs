using System.Linq;

namespace Intro
{
    class SortByHeight
    {
        int[] sortByHeight(int[] a)
        {
            var people = a.Where(p => p > 0).OrderBy(p => p).ToArray();
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    a[i] = people[index++];
                }
            }
            return a;
        }
    }
}
