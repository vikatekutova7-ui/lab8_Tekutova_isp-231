//using MyApp.Models;
//using System.Drawing;
//using System.Xml.Linq;
//namespace dz_tekutova_isp_231
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //1
//            Car car1 = new Car();
//            car1.Brand = "Jeep";
//            car1.Model = "1234";
//            car1.Year = 2024;
//            car1.Mileage = 1;
//            car1.PrintInfo();
//            Console.WriteLine();
//            Car car2 = new Car();
//            car2.Brand = "Lada";
//            car2.Model = "Granta";
//            car2.Year = 2025;
//            car2.Mileage = 0;
//            car2.PrintInfo();
//            //2
//            User user = new User();
//            user.Name = "Vika";
//            user.Email = "vikatekutova@gmail.com";
//            user.IsActive = true;
//            user.Vivod();
//            //3
//            ValueChecker checker = new ValueChecker();
//            checker.CheckType(5);
//            checker.CheckType(3.14);
//            checker.CheckType(true);
//            checker.CheckType("vsem privet");

//            //4
//            ex4.System mySystem = new ex4.System();
//            mySystem.PrintVersion();
//            global::System.Console.WriteLine("Эта строка выведена с помощью global::System.Console.WriteLine()");

//            //5
//            Point point = new Point(10, 10);
//            Rectangle rectangle = new Rectangle(20, 15, point);

//            rectangle.PrintInfo();
//            Console.WriteLine($"Площадь: {rectangle.CalculateArea()}");
//            Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter()}");
//            Point[] testPoints = new Point[]
//            {new Point(15, 15),
//            new Point(5, 5),
//            new Point(25, 20)};
//            foreach (Point testPoint in testPoints)
//            {
//                bool contains = rectangle.ContainsPoint(testPoint);
//                Console.WriteLine($"Точка {testPoint} внутри прямоугольника: {contains}");
//            }
//        }
//    }
//    public struct Point
//    {
//        public int X { get; set; }
//        public int Y { get; set; }
//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }
//        public override string ToString()
//        {
//            return $"({X}, {Y})";
//        }
//    }
//    public struct Rectangle
//    {
//        public int Width { get; set; }
//        public int Height { get; set; }
//        public Point Position { get; set; }

//        public Rectangle(int width, int height, Point position)
//        {
//            Width = width;
//            Height = height;
//            Position = position;
//        }
//        public int CalculateArea()
//        {
//            return Width * Height;
//        }
//        public int CalculatePerimeter()
//        {
//            return 2 * (Width + Height);
//        }
//        public bool ContainsPoint(Point point)
//        {
//            return point.X >= Position.X &&
//                   point.X <= Position.X + Width &&
//                   point.Y >= Position.Y &&
//                   point.Y <= Position.Y + Height;
//        }
//        public void PrintInfo()
//        {
//            Console.WriteLine($"Прямоугольник: позиция {Position}, ширина {Width}, высота {Height}");
//        }
//    }
//}
//namespace ex4
//{
//    public class System
//    {
//        public string version { get; set; } = "my_version";

//        public void PrintVersion()
//        {
//            Console.WriteLine($"Моя версия системы: {version}");
//        }
//    }
//}
