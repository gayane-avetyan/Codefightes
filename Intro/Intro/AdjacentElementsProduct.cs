namespace Intro
{
    class AdjacentElementsProduct
    {
        public int adjacentElementsProduct(int[] inputArray)
        {
            int max = int.MinValue;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] * inputArray[i + 1] > max)
                {
                    max = inputArray[i] * inputArray[i + 1];
                }
            }
            return max;
        }
    }
}
