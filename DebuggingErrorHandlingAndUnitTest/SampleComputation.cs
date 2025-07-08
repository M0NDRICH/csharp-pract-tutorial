using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingErrorHandlingAndUnitTest
{
    public class SampleComputation
    {
        public int Compute(int num1, int num2, SampleOperator op)
        {
            switch (op)
            {
                case SampleOperator.Add: return num1 + num2;
                case SampleOperator.Divide: return num1 / num2;
            }

            return 0;
        }
    }

    public enum SampleOperator
    {
        Add,
        Subtract,
        Divide,
        Multiply
    }
}
