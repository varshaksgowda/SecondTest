// See https://aka.ms/new-console-template for more information
namespace Babydress { 
public class BabyDress
{
    public string Color { get; set; }
    public int Size { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
}

class BabyDressUtility
{
    public void AddDressToCart(BabyDress dress)
    {
        Program.DressCart.Add(dress);
    }
    public bool  RemoveDressFromCart(string Brand)
    {
        foreach (var BrandObj in Program.DressCart)
        {
            if (BrandObj.Brand == Brand)
            {
                Program.DressCart.Remove(BrandObj);
                return true;
            }
        }
                return false;
            }
    }
    public class Program
    {
        public static List<BabyDress> DressCart { get; set; } = new List<BabyDress>();

        public static void Main(string[] args)
        {
            BabyDressUtility babyDressUtility = new BabyDressUtility();
            while (true)
            {
                Console.WriteLine("1.Add to cart");
                Console.WriteLine("2.Remove dress from cart");
                Console.WriteLine("3.Exit");
                Console.WriteLine("enter your choice:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("enter the dress size");
                        int size = int.Parse(Console.ReadLine());

                        Console.WriteLine("enter the dress color");
                        string color = Console.ReadLine();

                        Console.WriteLine("enter the dress brand");
                        string brand = Console.ReadLine();

                        Console.WriteLine("enter the dress price");
                        double price = double.Parse(Console.ReadLine());

                        BabyDress dress = new BabyDress();
                        dress.Price = price;
                        dress.Size = size;
                        dress.Brand = brand;
                        dress.Color = color;
                        babyDressUtility.AddDressToCart(dress);
                        Console.WriteLine("successfully added to the dress cart");

                        break;
                    case "2":
                        Console.WriteLine("enter the brand to remove  the dress from cart");
                        string brandToRemove = Console.ReadLine();
                        if (babyDressUtility.RemoveDressFromCart(brandToRemove))
                        {
                            Console.WriteLine("succeffully removed from the cart");
                        }
                        else
                        {
                            Console.WriteLine("dress is not found in the cart");
                        }
                        break;
                    case "3":
                        Console.WriteLine("thank you");
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;


                        Console.WriteLine("successfully removed from the cart");
                }

            }
        }
    }
}