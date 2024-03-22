namespace HW3
{
    public class Website
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public string IPAddress { get; set; }

        public void InputData()
        {
            Console.WriteLine("\nEnter Website Information:");
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("URL: ");
            URL = Console.ReadLine();

            Console.Write("Description: ");
            Description = Console.ReadLine();

            Console.Write("IP Address: ");
            IPAddress = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nWebsite Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"URL: {URL}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"IP Address: {IPAddress}");
        }
    }
}
