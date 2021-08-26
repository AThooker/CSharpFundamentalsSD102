using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_VariableTypesFirstDemo
{
    class VariableTypes
    {
        static void Main(string[] args)
        {
            short age = 25;
            byte jerseyNumber = 32;
            var weight = 185.6;
            var isTired = false;
            //Floating point numbers
            float x = 10.0f;
            double y = 10.0 / 3.0;
            decimal z = 10.0m / 3.0m;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadLine();

            //Char
            char firstLetter;

            //bool 
            bool isThirsty = false;
            bool isHappy = true;

            //Type Caseing

            //Implicit Casting -- char -> -> long
            char letterA = 'a';
            int asciiValue = letterA;

            Console.WriteLine(asciiValue);
            Console.ReadLine();
            Console.Clear();
            // Explicit Casting -- double -> float -> long -> int -> char 
            double waterLeftInBottle = 12.6;
            int waterLeftInbottleInt = (int)waterLeftInBottle;
            string sethAge = "25";
            double sethAgeInt = Double.Parse(sethAge);

            Console.WriteLine("Hey how old are you?");
            string userAge = Console.ReadLine();
            int userAgeInt = Int32.Parse(userAge);
            Console.WriteLine($"Hey you will be {userAgeInt + 1} next year");
            Console.ReadLine();

            string fname = "Austin";
            string lname = "Hooker";
            Console.WriteLine($"{fname} {lname}"); //interpolation

            Console.WriteLine("Hey" + fname + "how is your day?"); //concatenation

            //operators
            //arithmetic operators
            int add = 5 + 2;
            int subtract = 5 - 2;
            int multiply = 5 * 2;
            double divide = 5 / 2.0;
            int remainder = 6 % 2;
            int increment = 5;
            increment++;
            int decrement = 5;
            decrement--;



            //Assignment Operators
            int xyz = 20;
            xyz += 12;
            Console.WriteLine(xyz);


            //Comparison Operators
            int num1 = 3;
            int num2 = 6;
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(num1 >= num2);

            //Logical Operators
            int num3 = 1;
            int num4 = 4;
            bool andBool = num3 > 0 && num4 > 6;
            bool orBool = num3 > 0 || num4 > 6;
            Console.WriteLine(num3 > -3 || num4 < 6);

            Console.ReadLine();

        }
    }
}
