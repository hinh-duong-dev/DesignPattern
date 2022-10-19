﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class NoDiscountStrategy : IPromotionStrategy
    {
        public double DoDiscount(double price)
        {
            return price;
        }
    }
}
