using System;

namespace lab8_Tekutova_isp_231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ivan";
            person.Age = 37;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            person.Age = -23;
            Console.WriteLine(person.Age);
            var apple = new Product { Name = "Яблоко", Price = 10.5m, Quantity = 5 };
            var banana = new Product { Name = "Банан", Price = 7.2m, Quantity = -2 };

            Console.WriteLine($"{apple.Name} x {apple.Quantity} = {apple.TotalPrice} руб.");
            Console.WriteLine($"{banana.Name} x {banana.Quantity} = {banana.TotalPrice} руб.");
            
            Hero hero = new Hero("Ривен", 120);
            Console.WriteLine($"Имя героя: {hero.Name} \nУровень героя: {hero.Level} \nМана: {hero.Mana} \nСтатус: {hero.Status}");

            hero.TakeDamage(50);
            hero.Heal(30);
            hero.TakeDamage(200);
            hero.Heal(50);
        }
    }
}
