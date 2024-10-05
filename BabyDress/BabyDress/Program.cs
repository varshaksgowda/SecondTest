// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

 public class BabyDress
{
    public int Size { get; set; }
    public string Color { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
}
 public class BabyDressUtility
{
    public void AddDressToCart(BabyDress dress)
    {
        Program.DressesCart.Add(dress);
    }

    public bool RemoveDressFromCart(string brand)
    {
        var dressToRemove = Program.DressesCart.FirstOrDefault(d => d.Brand == brand);
        if (dressToRemove != null)
        {
            Program.DressesCart.Remove(dressToRemove);
            return true;
        }
        return false;
    }
}
 class Program
{
    public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>();

    public static void Main(string[] args)
    {
        BabyDressUtility babyDressUtility = new BabyDressUtility();

        while (true)
        {
            Console.WriteLine("1. Add dress to cart");
            Console.WriteLine("2. Remove dress from cart");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the dress size: ");
                    int size = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the dress color: ");
                    string color = Console.ReadLine();

                    Console.Write("Enter the dress brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter the dress price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    BabyDress dress = new BabyDress { Size = size, Color = color, Brand = brand, Price = price };
                    babyDressUtility.AddDressToCart(dress);
                    Console.WriteLine("Successfully added to the cart");
                    break;
                case "2":
                    Console.Write("Enter the dress brand to remove the dress from cart: ");
                    string brandToRemove = Console.ReadLine();

                    if (babyDressUtility.RemoveDressFromCart(brandToRemove))
                    {
                        Console.WriteLine("Successfully removed from the cart");
                    }
                    else
                    {
                        Console.WriteLine("Dress not found in the cart");
                    }
                    break;
                case "3":
                    Console.WriteLine("Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

}
