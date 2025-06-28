// See https://aka.ms/new-console-template for more information

namespace FlowControl
{
    class Program 
    {
        static void Main(string[] args)
        {
            #region -- If..Else If..If --
            const int MAX_MINOR_AGE = 17;
            const int MIN_SENIOR_AGE = 60;
            var isPWD = true;
            var age = 25;

            if (age <= MAX_MINOR_AGE || age >= MIN_SENIOR_AGE)
            {
                Console.WriteLine("Add minor and senior discount");
            }
            else if (isPWD) 
            {
                //Console.WriteLine("Add PWD discount");
            }
            else
            {
                Console.WriteLine("no Discount");
            }

            //Client Requirements: No 5 discount for ADULT.
            //implementation #1
            if(age > MAX_MINOR_AGE && age < MIN_SENIOR_AGE)
            {
            }
            else
            {
                //Console.WriteLine("added 5 discount");
            }

            //implementation #2
            if (!(age > MAX_MINOR_AGE && age < MIN_SENIOR_AGE))
            {
                //Console.WriteLine("added 5 discount");
            }
            #endregion

            #region -- Switch --
            var Age = 15;
            switch (Age)
            {
                case 1:
                    Console.WriteLine("baby");
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    //Console.WriteLine("teen");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            #endregion

            #region -- While --
            var count = 0;
            while(count < 3)
            {
                count++;
                //Console.WriteLine(count);
            }
            #endregion

            #region -- Do While --
            do
            {
                //Console.WriteLine("Print using do while");
                //Console.WriteLine(count);
                count++;
            } while (count < 3);
            #endregion

            #region -- For Loop --

            //for(var index = 0; index <= 5; index++)
            //{
            //    Console.WriteLine($"index value {index}");
            //}

            var nameSegments = new[] {"Rich", "mond", "M"};
            foreach(var segment in nameSegments)
            {
                Console.WriteLine($"segment value: {segment}");
            }

            #endregion

        }
    }
}