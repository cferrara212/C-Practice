using System;
using System.Collections.Generic;
using System.Text;

namespace exercises
{
    public class CSharpExercises
    {
        // member variables
        


        // member constructor


        // member methods

        public double RunPayCalculator(double hoursWorked, double payRate, double overtimeHours, double overtimePayRate)
        {
             double totalPay;
                totalPay = hoursWorked * payRate + overtimeHours * overtimePayRate;

            return totalPay;
        }
       
    }
}
