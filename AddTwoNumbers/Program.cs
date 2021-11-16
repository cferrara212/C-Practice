using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne;
            double numberTwo;
            double sum;
            string name;

            Console.WriteLine("Hello, what is your name?");
            string yourName = Console.ReadLine();
            name = yourName;

            Console.WriteLine("Hello " + name);
            Console.WriteLine("lets add two numbers together!");
            Console.WriteLine("please type a number");
            string firstNumber = Console.ReadLine();
            numberOne = double.Parse(firstNumber);

            Console.WriteLine("Ok, your first number is " + numberOne);
            Console.WriteLine("Please type your second number!");
            string secondNumber = Console.ReadLine();
            numberTwo = double.Parse(secondNumber);

            Console.WriteLine("Ok, your first number is " + numberOne);
            Console.WriteLine("Your second number is " + numberTwo);
            sum = numberOne + numberTwo;
            Console.WriteLine("The sum of your two numbers is " + sum);
            Console.ReadLine();


        }   
    }
}
