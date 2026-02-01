namespace Operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(4);
            Circle c2 = new Circle(7);

            double sum = c1 + c2;
            double difference = c1 - c2;
          
            Console.WriteLine($"Sum of areas: {sum}");
            Console.WriteLine($"Difference of areas: {difference}");
        }
    }
}

