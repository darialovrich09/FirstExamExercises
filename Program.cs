namespace _01.Festival
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double decoration = rent * 0.25;
            double sound = decoration + 50;
            double security = 0.15 * (rent + sound);
            double cleanup = 0.1 * rent;
            double totalPrice = rent + decoration + sound + security + cleanup;

            Console.WriteLine(totalPrice);
        }
    }
}
