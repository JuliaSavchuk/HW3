namespace HW3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------Task 1-------\n");
            Task1.TaskNum1(5, '*');

            Console.WriteLine("\n-------Task 2-------\n");
            Console.WriteLine("Enter num:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Task2.TaskNum2(number);
            Console.WriteLine(Task2.TaskNum2(number));

            Console.WriteLine("\n-------Task 3-------\n");
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            int[] filteredArray = Task3.TaskNum3(originalArray, filterArray);

            Console.WriteLine(string.Join(" ", filteredArray));

            Console.WriteLine("\n-------Task 4-------\n");
            Website website = new Website();
            website.InputData();
            website.DisplayData();

            Console.WriteLine("\n-------Task 5-------\n");
            Journal journal = new Journal();
            journal.InputData();
            journal.DisplayData();

            Console.WriteLine("\n-------Task 6-------\n");
            Store store = new Store();
            store.InputData();
            store.DisplayData();

        }
    }
}
