namespace Intro
{
    class AddBorder
    {
        string[] addBorder(string[] picture)
        {
            string asterix = new string('*', picture[0].Length + 2);
            string[] result = new string[picture.Length + 2];
            result[0] = asterix;
            for (int i = 1; i < result.Length - 1; i++)
            {
                result[i] = "*" + picture[i - 1] + "*";
            }
            result[picture.Length + 1] = asterix;
            return result;
        }
    }
}
