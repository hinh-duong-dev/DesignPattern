namespace StrategyPattern
{
    class FiftyPercentDiscountStrategy : IPromotionStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.5;
        }
    }
}
