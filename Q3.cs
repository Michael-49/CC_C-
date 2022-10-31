using System;

namespace MaximumEnrolement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total Students Placed in CS: ");
            int cs= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Students Placed in MECH: ");
            int mech = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Students Placed in MET: ");
            int met = Convert.ToInt32(Console.ReadLine());
            int big = cs;
            if(cs>mech)
            {
                if(cs>met)
                {
                    Console.WriteLine("Highest placement CS");
                }
                else if(cs==met)
                {
                    Console.WriteLine("Highest placement CS");
                    Console.WriteLine("Highest placement MET");
                }
                else
                {
                    Console.WriteLine("Highest placement MET");
                }
                
            }
            else if(mech>cs)
            {
                if (mech > met)
                {
                    Console.WriteLine("Highest placement MECH");
                }
                else if (mech == met)
                {
                    Console.WriteLine("Highest placement MECH");
                    Console.WriteLine("Highest placement MET");
                }
                else
                {
                    Console.WriteLine("Highest placement MET");
                }
            }
            else
            {
                if (mech > met)
                {
                    Console.WriteLine("Highest placement CS");
                    Console.WriteLine("Highest placement MECH");
                }
                else if (mech == met)
                {
                    Console.WriteLine("Highest placement CS");
                    Console.WriteLine("Highest placement MECH");
                    Console.WriteLine("Highest placement MET");
                }
                else
                {
                    Console.WriteLine("Highest placement MET");
                }
            }



            }

        }
    }