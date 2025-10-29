using System.Xml.Linq;

struct Person
{
    public string name;
    public int age = 1;
    public Person(string name = "Artem", int age = 1) { }
    public void Print() => Console.WriteLine($"Имя {name} Возраст: {age}");
    
    static void Main(string[] args)
    {
        Person garen;
        garen.name = "Гарен";
        garen.age = 25;
        garen.Print();
        Person ahri = new();
        Person brand = new("Brand");
        Person darius = new("Darius", 25);
        ahri.Print();
        brand.Print();
        darius.Print();
        var p1 = new Point2D(10, 20);
        var p2 = new Point2D(13, 24);
        Console.WriteLine($"Расстояние: {p1.DistanceTo(p2):F2}");
        Calculate(5);
        State state1 = new State();
        Country country1 = new Country();
    }
    static void Calculate(int t)
    {
        //int x = 6;
        object x = 6;
        int y = 7;
        int z = y + t;
    }
}
struct State
{
    public int x; public int y; public Country country;
    public State()
    {
        x = 0; y = 0; country = new Country();
    }
}
class Country
{
    public int x; public int y;
}

    public struct Point2D
    {
        public int X;
        public int Y;

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point2D other)
        {
            int dx = X - other.X;
            int dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

