// See https://aka.ms/new-console-template for more information
public class Fishs
{
public string Species { get; set; }
    public double PricePerFish { get; set; }
}
public class FishUtility : Fishs
{
    public void Addfish(string species,double pricePerFish)
    {
        Species=species;
        PricePerFish=pricePerFish;
    }
    public bool IsValidSpecies()
    {
        return Species == "Clownfish" || Species=="GoldFish";
    }
    public double CalculatePrice(int NumberOfFish)
    {
        if(!IsValidSpecies()) return 0;
        double additionalcharges = 0;
        if (Species == "Clownfish")
        {
            additionalcharges = 100;
        }
        else if (Species == "Goldfish")
        {
            additionalcharges = 150;
        }
        return NumberOfFish * PricePerFish + additionalcharges;
    }
}
class program
{
    static void Main(string[] args)
    {
        FishUtility fishUtility = new FishUtility();
        Console.WriteLine("enter the species name:");
        string species = Console.ReadLine();
        Console.WriteLine("enter the price for fish:");
        double pricePerFish = Convert.ToDouble(Console.ReadLine());
        fishUtility.Addfish( species, pricePerFish);
        if (!fishUtility.IsValidSpecies())
        {
            Console.WriteLine($"{species} not found");
            return;
        }
        Console.WriteLine("enter the number of fishes you need to buy:");
        int NumberOfFishes=Convert.ToInt32(Console.ReadLine());
        double totalPrice=fishUtility.CalculatePrice(NumberOfFishes);
        Console.WriteLine($"Totak price :{totalPrice}");



    }
}
