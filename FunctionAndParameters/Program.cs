﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace FunctionAndParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            #region -- Function, Void and Parameters --

            #region -- Initial Coding --
            /*
            program.PrintName();
            program.PrintNameWithParam("Richmond");
            program.PrintNameWithAge("Richmond", 21);
            */
            #endregion

            #region -- Optional With Default --
            /*
            //program.PrintNumbers("1", "4", "3");
            program.ProcessNumbers(2);
            Console.WriteLine("************");
            program.ProcessNumbers(5, secondNumber: 3);
            Console.WriteLine("************");
            program.ProcessNumbers(10, name: "Frace");
            */
            #endregion
            /*
            program.PrintMyName("Sample Name");
            //Static
            Program.MyStaticPrintName("My Name");
            */

            #endregion

            #region -- Function With Return Type --
            /*
            var sumOf1And2 = program.AddTwoNumbers(1, 2);
            Console.WriteLine($"Sum of 1 and 2: {sumOf1And2}");
            */
            //Console.WriteLine($"Sample result: {program.AddNumbers(5, Operator.Add, 2, 3, 4)}");
            #endregion

            #region -- Ref --
            var string1 = "Demo";
            var string2 = "Demo";
            program.ModifyText(ref string2);
            //Console.WriteLine($"{string1}{string2}");
            #endregion

            #region -- Out --
            //string errorMessage;
            var result1 = program.Process(10, 5, out string errorMessage);
            //if (string.IsNullOrEmpty(errorMessage))
            //    Console.WriteLine($"result1: {result1}");
            //else
            //    Console.WriteLine($"result1 error: {errorMessage}");
            #endregion

            #region -- Recursive (Factorial) --
            //Factorial of 3 = 3 * 2 * 1
            Console.WriteLine($"Factorial of 3: {program.SampleFactorial(3)}");
            //Factorail of 5 = 5 * 4 * 3 * 2 *1
            Console.WriteLine($"Factorial of 5: {program.SampleFactorial(5)}");
            #endregion

        }
        #region -- Function, Void and Parameter --
        #region -- For Inital Coding --
        //Void without parameter
        public void PrintName()
        {
            Console.WriteLine("using PrintName()");
            var name = "any name";
            Console.WriteLine($"name: {name}");
        }

        public void PrintNameWithParam(string name)
        {
            Console.WriteLine("using PrintNameWithParam(string name)");
            Console.WriteLine(name);
        }

        public void PrintNameWithAge(string name, int age)
        {
            Console.WriteLine("PrintNameWithAge(string name, int age)");
            Console.WriteLine($"name: {name}, age: {age}");
        }
        #endregion

        #region -- Params Keyword --
        //Using params keyword
        public void PrintNumbers(params string[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }
        #endregion

        #region -- Optional With Default --
        public void ProcessNumbers(long firstNumber = 1, int? secondNumber = null, string name = "Richmond")
        {
            Console.WriteLine($"1st: {firstNumber}, 2nd: {(secondNumber.HasValue ? secondNumber.Value : string.Empty)}");
            Console.WriteLine($"name: {name}");
        }
        #endregion

        public void PrintMyName(string myName) => Console.WriteLine(myName);
        public static void MyStaticPrintName(string name) => Console.WriteLine(name);
        #endregion

        #region -- Function With Return Type And Void with Return --
        public int AddTwoNumbers(int number1, int number2)
        {
            Console.WriteLine($"num1: {number1}, num2: {number2}");

            return number1 + number2;
        }

        public int AddNumbers(int num1, Operator op = Operator.Add, params int[] otherNumbers)
        {
            var sumOfOtherNumbers = otherNumbers.Sum();

            switch (op)
            {
                case Operator.Add: return num1 + sumOfOtherNumbers;
                case Operator.Subtract: return num1 - sumOfOtherNumbers;
                case Operator.Multiply: return num1 * sumOfOtherNumbers;
                case Operator.Divide: return num1 / sumOfOtherNumbers;
                default: return 0;
            }
        }

        public void ReturnRightAwaySample(int num)
        {
            Console.WriteLine("Start Process");
            if (num == 0)
            {
                Console.WriteLine("Terminate Process");
                return;
            }
            Console.WriteLine($"End Process for num: {num}");
        }
        #endregion

        #region -- Ref --
        public void PrintDemoText(ref string demo)
        {
            Console.WriteLine(demo);
        }

        public void ModifyText(ref string demo)
        {
            demo = "New";
        }
        #endregion

        #region -- Out --
        public int Process(int a, int b, out string messages)
        {
            messages = null;
            if(b == 0)
            {
                messages = "Can't divide by 0";
                return 0;
            }
            return a / b;
        }
        #endregion

        #region -- Recursive (Factorial) --
        public int SampleFactorial(int number)
        {
            if (number == 1)
                return number;

            return number * SampleFactorial(number - 1);
        }
        #endregion

    }

    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}