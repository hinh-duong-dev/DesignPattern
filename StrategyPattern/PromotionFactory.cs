using System;

namespace StrategyPattern
{
    class PromotionFactory
    {
        public static IPromotionStrategy CreateStrategy(string number)
        {
            IPromotionStrategy promotionStrategy = null;

            if (int.Parse(number) == 20)
            {
                promotionStrategy = new TwentyPercentDiscountStrategy();
            }
            else if (int.Parse(number) == 50)
            {
                promotionStrategy = new FiftyPercentDiscountStrategy();
            }
            else if (int.Parse(number) == 0)
            {
                promotionStrategy = new NoDiscountStrategy();
            }
            else
            {
                throw new Exception("Promotion strategy invalid");
            }

            return promotionStrategy;
        }
    }
}
