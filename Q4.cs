using System;

namespace DesignTheDisplay
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Company Name");
            string c = Console.ReadLine();
            Console.WriteLine("Enter the Employee Name");
            string e = Console.ReadLine();
            Console.WriteLine("Enter the Project Name");
            string p = Console.ReadLine();
            Console.WriteLine("Enter the Year");
            int y = Convert.ToInt32(Console.ReadLine());
            entireMessage(c, e, p, y);

        }
        public static void headerMeaasge(string cname)
        {
            Console.WriteLine(cname + " Employee Information");
        }
        public static void footerMessage(int year)
        {
            Console.WriteLine("Copyright " + year);
            Console.WriteLine("All Rights Reserved.");
        }
        public static void entireMessage(string cname, string ename, string pname, int year)
        {
            headerMeaasge(cname);
            Console.WriteLine(ename);
            Console.WriteLine(pname);
            footerMessage(year);

        }

    }
}