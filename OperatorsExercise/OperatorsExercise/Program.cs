using System;
    namespace OperatorsExercise
    {
        class Program
        {
            static void Main(string[] args) 
            {
            //create 2 integer variables : int a (17) , int b (4)
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var reminder = a % b;

           
            Console.WriteLine($"{a} / {b} is {quotient} reminder {reminder}");
            Console.WriteLine("Please enter the radius of your circle!");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            Console.WriteLine(AreaOfCircle(radius));
            }
            
            //create a method that will calculate the area of a circle 
            public static double AreaOfCircle(double radius)
            {   
                var area = Math.PI * Math.Pow(radius, 2);
                return area;
            }

        }
    }