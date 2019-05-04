namespace Intro
{
    class AlmostIncreasingSequence
    {
        bool almostIncreasingSequence(int[] sequence)
        {
            int count = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    if (sequence.Length > i + 2 && sequence[i] >= sequence[i + 2] && i > 0 && sequence[i - 1] >= sequence[i + 1])
                    {
                        return false;
                    }
                    else
                        count++;
                }
                if (count > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
