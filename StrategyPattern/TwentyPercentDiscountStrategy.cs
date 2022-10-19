namespace StrategyPattern
{
    class TwentyPercentDiscountStrategy : IPromotionStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.8;
        }
    }
}
