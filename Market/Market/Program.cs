using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            BronzeCard bronze = new BronzeCard("Nikola", "Mitic", 1, 0);
            SilverdCard silver = new SilverdCard("Nikola", "Mitic", 1, 600);
            GoldCard gold = new GoldCard("Nikola", "Mitic", 1, 1500);

            double purchase = 150;
            Console.WriteLine("Bronze:");
            Console.WriteLine("Purchase value: $" + purchase);
            BronzeCard.getDiscountRate(bronze);
            BronzeCard.getDiscountAndTotal(bronze, purchase);
            Console.WriteLine();

            purchase = 850;
            Console.WriteLine("Silver:");
            Console.WriteLine("Purchase value: $" + purchase);
            SilverdCard.getDiscountRate(silver);
            SilverdCard.getDiscountAndTotal(silver, purchase);
            Console.WriteLine();

            purchase = 1300;
            Console.WriteLine("Gold:");
            Console.WriteLine("Purchase value: $" + purchase);
            GoldCard.getDiscountRate(gold);
            GoldCard.getDiscountAndTotal(gold, purchase);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
