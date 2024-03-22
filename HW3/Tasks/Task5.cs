namespace HW3
{
    public class Journal
    {
        public string Title { get; set; }
        public int YearFounded { get; set; }
        public string Description { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }

        public void InputData()
        {
            Console.WriteLine("Enter Journal Information:");
            Console.Write("Title: ");
            Title = Console.ReadLine();

            Console.Write("Year Founded: ");
            YearFounded = int.Parse(Console.ReadLine());

            Console.Write("Description: ");
            Description = Console.ReadLine();

            Console.Write("Contact Phone: ");
            ContactPhone = Console.ReadLine();

            Console.Write("Email: ");
            Email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nJournal Information:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year Founded: {YearFounded}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Contact Phone: {ContactPhone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
