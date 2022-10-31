using System;

namespace ClearanceSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name of the Product");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Price of the Product");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the product on SALE (yes/no) : ");
            string dec = Console.ReadLine();
            Console.WriteLine("Enter number of product sold in day 1  ");
            int d1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 2  ");
            int d2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 3  ");
            int d3 = Convert.ToInt32(Console.ReadLine());
            double s1, s2, s3,  t1, t2, t3;
            double dis1, dis2, dis3;
            if (dec == "yes")
            {
                dis1 = price * 7 / 100;
                s1 = price - dis1;
                dis2 = s1 * 7 / 100;
                s2 = s1 - dis2;
                dis3 = s2 * 7 / 100;
                s3 = s2 - dis3;
                t1 = s1 * d1;
                t2 = s2 * d2;
                t3 = s3 * d3;
                Console.WriteLine($"{name}");
                Console.WriteLine($"Day 1 sales total : {t1} ");
                Console.WriteLine($"Day 2 sales total : {t2} ");
                Console.WriteLine($"Day 3 sales total : {t3} ");
            }
            else
            {
                t1 = d1 * price;
                t2 = d2 * price;
                t3 = d3 * price;
                Console.WriteLine($"{name}");
                Console.WriteLine($"Day 1 sales total : {t1} ");
                Console.WriteLine($"Day 2 sales total : {t2} ");
                Console.WriteLine($"Day 3 sales total : {t3} ");

            }


        }
    }
}
