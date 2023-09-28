using System;
namespace L5Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNum1;
            string strNum2;
            double dblNum1;
            double dblNum2;

            Console.Write("Enter num 1 >>");
            strNum1 = Console.ReadLine();

            Console.Write("Enter Num 2 >>");
            strNum2 = Console.ReadLine();

            dblNum1 = Convert.ToDouble(strNum1);
            dblNum2 = Convert.ToDouble(strNum2);

            Console.WriteLine("The addition of {0} and {1} is {2}.", dblNum1, dblNum2, dblNum1 + dblNum2);
            Console.Read();

        }
    }
}

