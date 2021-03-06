﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class SpecialOrderGoods : Goods
    {
        public override int GetBonus(int _quantity, double _price)
        {
            return 0;
        }
        public override double GetDiscount(int _quantity, double _price)
        {
            double discount = 0;
            if (_quantity > 10)
                discount = _quantity * _price * 0.005; // 0.5%
            return discount;
        }
        public SpecialOrderGoods(string title)
            : base(title)
        { }

    }
}
