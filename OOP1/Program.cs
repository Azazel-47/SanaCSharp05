namespace OOP1;

public class Program
{
    public static void Main(String[] args)
    {
        Date startDate = new Date(2023, 04, 15, 12, 18);
        Date finishDate = new Date(2023, 04, 15, 17, 47);
        Airplane plane = new Airplane("Lviv", "Dubai", startDate, finishDate);
        Console.WriteLine($"StartCity: {plane.GetStartCity()}");
        Console.WriteLine($"FinishCity: {plane.GetFinishCity()}");
        Console.WriteLine($"StartDate: {plane.GetFullStartDate()}");
        Console.WriteLine($"StartDate: {plane.GetFullFinishDate()}");
        Console.WriteLine($"TotalTime: {plane.GetTotalTime()}");
        Product milk = new Product();
        Console.WriteLine($"Price in UAH: {milk.GetPriceInUAH()}");
        Console.WriteLine($"Total price in UAH: {milk.GetTotalPriceInUAH()}");
        Console.WriteLine($"Total Weight: {milk.GetTotalWeight()}");

    }
}