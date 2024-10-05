// See https://aka.ms/new-console-template for more information
namespace Product
{
    public class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
    }
    public class DeliveruService
    {
        public bool PlaceOrder(Product product)
        {
            if (product.Stock <= 0)
            {
                throw new System.Exception("product is out of stock");
            }
            
            else
            {
                Console.WriteLine("Order placed successfully");
                return true;
            }
            
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the product name:");
            string ProductName = Console.ReadLine();

            Console.WriteLine("enter the number of stock:");
            int stock = int.Parse(Console.ReadLine());
            Product product = new Product();

            product.Name=ProductName;
            product.Stock = stock;
           
            try
            {
                DeliveruService deliveryService = new DeliveruService();
                deliveryService.PlaceOrder(product);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

