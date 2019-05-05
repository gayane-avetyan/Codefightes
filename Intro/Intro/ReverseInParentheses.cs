using System.Linq;

namespace Intro
{
    class ReverseInParentheses
    {
        string reverseInParentheses(string inputString)
        {
            while (inputString.IndexOf('(') != -1)
            {
                int startIndex = inputString.LastIndexOf('(');
                int endIndex = inputString.IndexOf(')', startIndex) - startIndex + 1;
                string reverse = new string(inputString.Substring(startIndex, endIndex).Trim('(', ')').Reverse().ToArray());
                inputString = inputString.Replace(inputString.Substring(startIndex, endIndex), reverse);
            }
            return inputString;
        }

    }
}
