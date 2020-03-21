using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    class BronzeCard : PayDesk
    {
        public BronzeCard(string name, string surname, int id, double turnover) : base(name,surname,id,turnover)
        {
        }
        
        public override double calcucalteDiscountRate()
        {
            if (turnover > 300)
                discount = 2.5;
            else if (turnover > 100)
                discount = 1;
            else
                discount = 0;
            return discount;
        }
    }
}
