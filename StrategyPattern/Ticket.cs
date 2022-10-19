namespace StrategyPattern
{
    class Ticket
    {
        private readonly IPromotionStrategy _promotionStrategy;
        public Ticket(IPromotionStrategy promotionStrategy, double price)
        {
            _promotionStrategy = promotionStrategy;
            Price = price;
        }
        public double Price { get; set; }

        public double PriceAfterDiscount => _promotionStrategy.DoDiscount(Price);
    }
}
