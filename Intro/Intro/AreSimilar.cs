using System.Linq;

namespace Intro
{
    class AreSimilar
    {
        bool areSimilar(int[] a, int[] b)
        {
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] - b[i];
            }
            var result = c.Where(i => i != 0);
            var dif = a.Except(b);
            if (result.Count() == 2 && result.Sum() == 0 && dif.Count() == 0 || result.Count() == 0)
            {
                return true;
            }
            return false;
        }
    }
}
