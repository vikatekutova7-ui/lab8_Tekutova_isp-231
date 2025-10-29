namespace MyApp.Models
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public void Vivod()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Email: {Email}");
 
        }
    }
}