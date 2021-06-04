namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeEventSync flights = new ConsumeEventSync();
            flights.GetAllFlights();
        }
    }
}