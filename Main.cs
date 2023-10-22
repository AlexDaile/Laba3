namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод довжин сторін прямокутника
            double side1, side2;
            Console.WriteLine("Введіть довжину першої сторони: ");
            side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть довжину другої сторони: ");
            side2 = double.Parse(Console.ReadLine());

            // Утворення об'єкта класу Rectangle
            Rectangle rectangle = new Rectangle(side1, side2);

            // Виведення на екран
            Console.WriteLine("Периметр прямокутника: {0}", rectangle.Perimeter);
            Console.WriteLine("Площа прямокутника: {0}", rectangle.Area);
        }
    }
}