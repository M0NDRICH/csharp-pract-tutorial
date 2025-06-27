// See https://aka.ms/new-console-template for more information
using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args) 
        {
            #region --About Variables--
            #region -- Local Variables --
            //Local variables
            //explicit
            int sampleNumber = 3;
            //implicit
            var sampleNumberImplicit = 3;
            dynamic sampleNumberDynamic = 5;
            #endregion


            #region --Class & Instance Variables --

            //Instance Variable
            var variables2 = new Variables2();
            Console.WriteLine(variables2.samplePublicInt);
            variables2.samplePublicInt = 250;
            Console.WriteLine(variables2.samplePublicInt);

            //Class or Static Variable
            Console.WriteLine("************************");
            Console.WriteLine(Variables2.sampleStaticOrClassVariableInt);
            Variables2.sampleStaticOrClassVariableInt = 200;
            Console.WriteLine(Variables2.sampleStaticOrClassVariableInt);
            #endregion
            #endregion

            #region -- About Datatypes --

            // Parse & Convert
            string textOne = "3";
            var intOne = int.Parse(textOne);
            var result = intOne * 5;
            Console.WriteLine($"(Parse)Text One result: {result}");

            string textTwo = "Sample";
            int intTwo;
            bool isNum = int.TryParse(textTwo, out intTwo);
            Console.WriteLine($"Result Two using TryParse: {intTwo}");
            Console.WriteLine(isNum);

            string textThree = ":)";
            int intThree;
            if (int.TryParse(textThree, out intThree))
            {
                Console.WriteLine($"Result Three using TryParse: {intThree}");
            }
            else
            {
                Console.WriteLine($"Hindi naman number yung {textThree} ah?");
            }

            // Inline variable declaration
            string textFour = "***TEST***";
            if (int.TryParse(textFour, out int num))
            {
                Console.WriteLine($"Result Four using TryParse: {num} ");
            }
            else
            {
                Console.WriteLine($"Hindi naman number yung {textFour} ah?");
                Console.WriteLine($"tryparse result : {num}");
            }

            var intConverted = Convert.ToInt32(textOne);
            result = intConverted * 5;
            Console.WriteLine($"(Convert)Text One result: {result}");

            #endregion
        }
    }

    #region --Demo Class--

    public class Variables2
    {
        public static int sampleStaticOrClassVariableInt = 3;

        public int samplePublicInt = 500;
        private int samplePrivateInt = 100;

        #region -- Fields --

        int sampleFieldInt = 5;
        static int sampleStaticInt = 6;
        readonly long sampleLong;
        readonly long sampleLong2 = 10;

        const int sampleIntNaConst = 150;
        const float mathPI = 3.14F;

        #endregion

        public Variables2()
        {
            sampleLong = 500;
            sampleLong2 = 100;
        }
        public void SampleMethod1()
        {
            int sampleLocalInt = 1;
            var sampleLocalDouble = 1.5;
            sampleFieldInt = 0;
            sampleStaticInt = 0;
        }
        public void SampleMethod2()
        {
            int sample2Int = 1;
            sampleFieldInt = 0;
            sampleStaticInt = 0;
        }

        public static void SampleStaticMethod1()
        {
            //sampleFieldInt = 0; error static methods cant access non-static variables
            sampleStaticInt = 0;
        }
    }
    #endregion
}