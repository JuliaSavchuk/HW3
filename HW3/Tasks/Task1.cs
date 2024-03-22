namespace HW3
{
    internal class Task1
    {
        public static void TaskNum1(int sideLength, char symbol)
        {
            // Перевірка, щоб сторона квадрата була не менше 2
            if (sideLength < 2)
            {
                Console.WriteLine("The side of the square must be at least 2.");
                return;
            }

            // Відображення квадрата
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
