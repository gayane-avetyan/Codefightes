using System.Linq;

namespace Intro
{
    class AlternatingSums
    {
        int[] alternatingSums(int[] a)
        {
            int[] b = new int[2];
            b[0] = a.Where((i, index) => index % 2 == 0).Sum();
            b[1] = a.Where((i, index) => index % 2 != 0).Sum();
            return b;
        }
    }
}
