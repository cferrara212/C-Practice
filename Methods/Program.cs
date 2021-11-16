using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DoMath ourProblem = new DoMath(300,400);

            ourProblem.AddTwoNumbers();



            Can mountainDew = new Can("green-yellow");
            Can sprite = new Can("clear");

            mountainDew.Open();
            Console.WriteLine("You have opened a mountain dew");
            Console.ReadLine();
            mountainDew.TakeSip();
            Console.WriteLine("you take a sip of the mountain dew");
            Console.WriteLine("The mountain dew is now at " + mountainDew.percentageFull + " percent full");
            Console.ReadLine();
            mountainDew.TakeSip();
            Console.WriteLine("You take another sip of mountain dew");
            Console.WriteLine("The mountain dew is now at " + mountainDew.percentageFull + " percent full");
           
            Console.ReadLine();




            

            
  

            

        }
    }
}
