using System.Linq;

namespace Intro
{
    class IsIPv4Address
    {
        bool isIPv4Address(string inputString)
        {
            return inputString.Where(i => i == '.').Count() != 3 ? false : !inputString.Split('.').Any(i => i == "" || !int.TryParse(i, out int result) || result < 0 || result > 255);
        }
    }
}
