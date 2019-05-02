using System.Linq;

namespace Intro
{
    class MakeArrayConsecutive2
    {
        public int makeArrayConsecutive2(int[] statues)
        {
            return statues.Max() - statues.Min() - statues.Length + 1;
        }
    }
}
