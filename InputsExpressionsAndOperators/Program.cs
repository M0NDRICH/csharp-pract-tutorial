// See https://aka.ms/new-console-template for more information
using System;
class Program 
{
    static void Main(string[] args)
    {
        #region -- Inputs --
        #region -- Write --
        Console.Write($"a{Environment.NewLine}"); // after 'a' it creates new line
        Console.Write("b\n");

        Console.WriteLine('c');
        Console.WriteLine('d');

        #endregion

        #region -- Read --

        //Console.WriteLine("enter an input: ");
        //var input = Console.ReadLine();
        //Console.WriteLine($"{input}");

        //var readTest = Console.Read();
        //Console.WriteLine(readTest);

        Console.WriteLine("Input your age: ");
        var ageString = Console.ReadLine();
        //var status = "";

        int.TryParse(ageString, out int age);
        //if (age < 18)
        //{
        //    status = "minor";
        //} 
        //else
        //{
        //    status = "adult";
        var status = age < 18 ? "minor" : "adult";

        Console.WriteLine($"You're {age} years old and you're {status}.");

        #endregion

        #endregion

        #region -- Expressions & Operatos --

        #region -- Assignment Operator --

        var a = 5;
        a = 10;

        #endregion

        #region -- Arithmetic Operators --

        //Addition
        var num1 = 3;
        var num2 = 7;
        var num1And2Result = num1 + num2;
        num1And2Result = num1 + num2 + 100 + 10;

        //Subtraction
        var sub1 = 100;
        var sub2 = 90;
        var subResult = sub1 - sub2;

        //Multiplication
        var mul1 = 10;
        var mul2 = 10;
        var mulResult = mul1 * mul2;

        //Division
        var div1 = 10;
        var div2 = 10;
        var divResult = div1 / div2;

        //Modulus
        var mod1 = 9;
        var mod2 = 5;
        var modResult = mod1 % mod2;

        //Precedence : (), [], ++, --, *, /, %, +, -
        var samplePrecedence = (1 + 1) * 5 + 2 / 2 - 10 + 3;
        Console.WriteLine(samplePrecedence);

        #endregion

        #region -- Boolean Operators --

        var isActive = true;
        var isSuspended = false;

        var testAnd = isActive && isSuspended;
        var testOr = isActive || isSuspended;

        //Equality
        var eq1 = 100;
        var eq2 = 90;

        var testEq = eq1 == eq2;
        var testNotEq = eq1 != eq2;

        var testGreaterThan = eq1 > eq2;
        var testLessThan = eq1 < eq2;

        var testGreaterThanOrEqual = eq1 >= eq2;
        var testLessThanOrEqual = eq1 <= eq2;

        #endregion

        #region -- Null-Coalescing --

        var sampleString = "may laman";
        string nullNaString = null;

        var sampleResult1 = sampleString ?? "nilagyan nang laman";
        var sampleResult2 = nullNaString ?? "nilagyan nang laman";

        Console.WriteLine(sampleResult1);
        Console.WriteLine(sampleResult2);
        #endregion

        #region -- Unary --

        var trueValue = true;
        trueValue = !trueValue;

        /*
         * Post: <operand>++
         * Pre:  ++<operand>
         */

        var numberIncrementDecrement = 10;
        Console.WriteLine("Post Increment");
        //equivalent to: numberIncrementDecrement = numberIncrementDecrement + 1;
        Console.WriteLine(numberIncrementDecrement++);
        //equivalent to: numberIncrementDecrement = numberIncrementDecrement - 1;
        Console.WriteLine(numberIncrementDecrement--);

        numberIncrementDecrement = 10;
        Console.WriteLine("Pre Increment");
        //post incr and decr
        Console.WriteLine(++numberIncrementDecrement);
        Console.WriteLine(--numberIncrementDecrement);

        #endregion

        #region -- Ternary --

        var sampleStringTernary = "spaghetti";
        var result = sampleStringTernary == "spaghetti" ? "food" : "??Unknown??";

        Console.WriteLine(result);

        #endregion

        #endregion

        #region -- Pythagorean Theorem --

        Console.WriteLine("Input a value: ");
        var formulaA = double.Parse(Console.ReadLine());
        Console.WriteLine("Input b value: ");
        var formulaB = double.Parse(Console.ReadLine());

        var formulaResult = Math.Sqrt(Math.Pow(formulaA, 2) + Math.Pow(formulaB, 2));
        Console.WriteLine($"Sample C result: {formulaResult}");
        #endregion
    }
}