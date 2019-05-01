using System.Linq;

namespace Intro
{
    class CheckPalindrome
    {
        bool checkPalindrome(string inputString)
        {
            return inputString == new string(inputString.ToCharArray().Reverse().ToArray());
        }
    }
}
