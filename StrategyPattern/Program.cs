using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter promotion percent");
            string number = Console.ReadLine();
            IPromotionStrategy promotionStrategy = PromotionFactory.CreateStrategy(number);

            Ticket ticket = new Ticket(promotionStrategy, 100000);

            Console.WriteLine($"Price: {ticket.Price}");

            Console.WriteLine($"Price after apply {promotionStrategy.GetType().Name}: {ticket.PriceAfterDiscount}");

            Console.ReadKey();
        }
    }
}
