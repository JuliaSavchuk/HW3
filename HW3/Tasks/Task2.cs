namespace HW3
{
    internal class Task2
    {
        public static bool TaskNum2(int number)
        {

            int originalNumber = number;
            int reversedNumber = 0;

            // Реверсуємо число
            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            if (originalNumber == reversedNumber)
            {
                return true; // Якщо числа співпадають, то число - паліндром
            }
            else
            {
                return false; // Якщо числа відрізняються, то число не є паліндромом
            }
        }
    }
}
