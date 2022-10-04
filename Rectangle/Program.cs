namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 5);
            Console.WriteLine($"Площа: {rectangle.Area}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter}");
        }
    }
}