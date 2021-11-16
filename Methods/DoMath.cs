using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   public class DoMath

    {

        // public member variables

        public double yourNumber;
        public double myNumber;

        // constructors

        public DoMath(double yourNumber, double myNumber)
        {
            this.yourNumber = yourNumber;
            this.myNumber = myNumber;
        }

        public void AddTwoNumbers()
        {
            double result;
            result = yourNumber + myNumber;
          
            Console.WriteLine(" The sum of your numbers added together is " + result);
            Console.ReadLine();
        }
        
    }
}
