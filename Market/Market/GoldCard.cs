using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    class GoldCard : PayDesk
    {
        
        public GoldCard(string name, string surname, int id, double turnover) : base(name, surname, id, turnover)
        {
            
        }
        public override double calcucalteDiscountRate()
        {
            discount = 2;
            int br = (int)(turnover / 100);
            while (br > 0 && discount < 10)
            {
                discount++;
                br--;
            }
            return discount;
        }

    }
}
