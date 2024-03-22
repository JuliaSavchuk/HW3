namespace HW3
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void InputData()
        {
            Console.WriteLine("Enter Store Information:");
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Address: ");
            Address = Console.ReadLine();

            Console.Write("Description: ");
            Description = Console.ReadLine();

            Console.Write("Phone: ");
            Phone = Console.ReadLine();

            Console.Write("Email: ");
            Email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nStore Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
