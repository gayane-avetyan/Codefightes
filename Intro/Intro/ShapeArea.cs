namespace Intro
{
    class ShapeArea
    {
        int shapeArea(int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result += 4 * i;
            }
            return result;
        }
    }
}
