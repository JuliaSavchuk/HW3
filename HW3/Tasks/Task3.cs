namespace HW3
{
    internal class Task3
    {
        public static int[] TaskNum3(int[] originalArray, int[] filterArray)
        {
            int count = 0;
            for (int i = 0; i < originalArray.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < filterArray.Length; j++)
                {
                    if (originalArray[i] == filterArray[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < originalArray.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < filterArray.Length; j++)
                {
                    if (originalArray[i] == filterArray[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    result[index++] = originalArray[i];
                }
            }

            return result;
        }
    }
}
