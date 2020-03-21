using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    class SilverdCard : PayDesk
    {
        public SilverdCard(string name, string surname, int id, double turnover) : base(name, surname, id, turnover)
        {
            
        }
        public override double calcucalteDiscountRate( )
        {
            if (turnover > 300)
                discount = 3.5;
            else
                discount = 2;
            return discount;
        }
    }
}