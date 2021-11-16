using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursWorked;
            double payRate;
            double totalPay;

            hoursWorked = 35;
            payRate = 7.25;
            totalPay = hoursWorked * payRate;
            Console.WriteLine(totalPay);
            Console.ReadLine();
        }
    }
}
