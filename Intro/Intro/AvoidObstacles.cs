namespace Intro
{
    class AvoidObstacles
    {
        int avoidObstacles(int[] inputArray)
        {
            int sum = 1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % sum == 0)
                {
                    i = -1;
                    sum++;
                }
            }
            return sum;
        }
    }
}
