namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new car();
            carOne.make = "kia";
            carOne.model = "soul";
            carOne.year = 2018;
            Console.WriteLine($" this is a {carOne.make} {carOne.model},made in the year {carOne.year}.");
        }
    }
}
