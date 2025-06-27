// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        #region -- Variable Decleration Demo --

        // syntax: <datatype> <name identifier>
        int m1, m2, m3; // Multiple

        // single per line
        int s1 = 1;
        int s2;
        int s3;

        // Decleration of variable demo
        short shortA = 1;
        int intA = 1;
        long longA = 1;

        intA = shortA;
        longA = intA;

        var intAndLong = intA + longA;

        bool trueVal = true; 
        bool falseVal = false;

        char charA = 'A';
        string nullString;
        string stringWithValue = "test";

        float floatA = 1.2F;
        double doubleA = 1.2D;
        doubleA = floatA;
        var floatAndDouble = floatA + doubleA;

        decimal decimalA = 1.2M;
        string word = "Hello world";

        #endregion
    }
}
