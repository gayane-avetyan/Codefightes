namespace Intro
{
    class CommonCharacterCount
    {
        int commonCharacterCount(string s1, string s2)
        {
            int result = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        result++;
                        s2 = s2.Remove(j, 1);
                        break;
                    }
                }
            }
            return result;
        }
    }
}
