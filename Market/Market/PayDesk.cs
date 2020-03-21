using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    abstract class PayDesk
    {
        private string name;
        private string surname;
        private int id;
        protected double turnover;
        protected double discount;

        public PayDesk(string name, string surname, int id, double turnoverr)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
            this.turnover = turnoverr;
            this.discount = 0;
        }
        public static void getDiscountRate(PayDesk pd)
        {
            double discountRate = pd.calcucalteDiscountRate();
            Console.WriteLine("Discount rate: " + discountRate + "%");
        }
        public abstract double calcucalteDiscountRate();
        public static void getDiscountAndTotal(PayDesk pd, double purchase)
        {
            double diss = purchase * pd.discount / 100;
            double total = purchase - diss;
            Console.WriteLine("Discount: $" + diss);
            Console.WriteLine("Total: $" + total);
        }


    }
}
