using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double hoursWorked;
            double payRate;
            double overtimePayRate;
            double overtimeHours;
           
           
           
            
            CSharpExercises payCalculator = new CSharpExercises();
            Console.WriteLine("Hello, for all entries, please hit the enter button after your have answered the question.");
            Console.WriteLine("What is your name?");
                string yourName = Console.ReadLine();
                name = yourName;
                Console.WriteLine("Ok" + " " + name);
                Console.WriteLine("we are going to find your total weekly pay");
            
            Console.WriteLine("how many hours did you work this week?");
                string yourHoursWorked = Console.ReadLine();
                hoursWorked =double.Parse (yourHoursWorked);
                Console.WriteLine("Wonderful, now how many dollars do you get paid per hour?");
                string yourPayRate = Console.ReadLine();
                payRate = double.Parse(yourPayRate);

            if (hoursWorked > 40)
            {
                overtimeHours = hoursWorked - 40;
                hoursWorked = 40;
                overtimePayRate = payRate * 1.5;
            }
            
            else 
            {
                hoursWorked = double.Parse(yourHoursWorked);
                overtimeHours = 0;
                overtimePayRate = 0;
            }

            

            double totalPay = payCalculator.RunPayCalculator(hoursWorked, payRate, overtimeHours, overtimePayRate);

            Console.WriteLine("OK" + name + " your total pay for the hours you worked is " + totalPay);
        }
    }
}
