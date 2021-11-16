using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
           Student chris = new Student();
            Student bryan = new Student();

            chris.name = "chris";
            chris.overallGradePercentage = 100;

            bryan.name = "bryan";
            bryan.overallGradePercentage = 95.4;

            Console.WriteLine(chris.name);
            Console.WriteLine(chris.overallGradePercentage);
            Console.WriteLine(bryan.name);
            Console.WriteLine(bryan.overallGradePercentage);
            Console.ReadLine();


            car myCar = new car();
            car aliciasCar = new car();

            myCar.make = "dodge";
            myCar.model = "ram";
            aliciasCar.model = "FJ";
            aliciasCar.make = "toyota";
            myCar.isConvertible = false;
            aliciasCar.isConvertible = false;

            Console.WriteLine("Chris' car is a " + myCar.make + " " + myCar.model);
            Console.WriteLine(myCar.isConvertible);
            Console.WriteLine("Alicias car is a " + aliciasCar.make + " " + aliciasCar.model);
            Console.WriteLine(aliciasCar.isConvertible);
            Console.ReadLine();

        }
    }
}
