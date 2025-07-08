// See https://aka.ms/new-console-template for more information

namespace DebuggingErrorHandlingAndUnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.FirstChanceException += (sender, args) =>
            {
                if (args.Exception is WalangFirstnameException)
                {
                    Console.WriteLine("(From Event)nagka-error na WalangFirstNameException");
                }
            };
            #region -- Debugging Demo --
            var binary1 = "00001111"; //15
            var binary2 = "01000001"; //65

            var firstBits = GetBitValues(binary1);
            var secondBits = GetBitValues(binary2);

            //Console.WriteLine($"binary1: {binary1}, {string.Join(", ", firstBits)}: {firstBits.Sum()}");
            //Console.WriteLine($"binary2: {binary2}, {string.Join(", ", secondBits)}: {secondBits.Sum()}");
            #endregion

            #region -- Error/Exception Handling Demo --
            var number1 = 100;
            var number2 = 50;
            var number3 = 0;

            /*
            try
            {
                Console.WriteLine($"Addition result: {number1 + number2}");
                Console.WriteLine($"Addition Result: {number1 / number3}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Hindi  pwede mage divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally! tapos na yung try and catch.");
            }
            */

            #region -- Custom Exception --
            try
            {
                string firstName = null;
                string lastName = "ProgrammerTV";

                if (string.IsNullOrWhiteSpace(firstName))
                    throw new WalangFirstnameException();

                Console.WriteLine(firstName.ToLower());
                Console.WriteLine(lastName.ToLower());
            }
            catch (WalangFirstnameException ex)
            {
                Console.WriteLine("Walang first name");
                //throw;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Hindi pwede mag gamit nang function pag null");
            }
            catch
            {
                Console.WriteLine("Ako bahala sa ibang exceptions");
            }
            #endregion
            #endregion
        }

        #region -- Debugging --
        public static IEnumerable<int> GetBitValues(string binaryValue)
        {
            return binaryValue
                    .Reverse()
                    .Select((value, index) =>
                    {
                        return value == '1' ? (int)Math.Pow(2, index) : 0;
                    })
                    .Reverse();
        }
        #endregion
    }
}