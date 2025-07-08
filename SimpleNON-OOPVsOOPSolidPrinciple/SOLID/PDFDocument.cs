using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNON_OOPVsOOPSolidPrinciple.SOLID
{
    //S - Single Responsibility
    public class PDFDocument
    {
        public void PrintPDF()
        { }

        public void CalculateQuadraticEquatin()
        { }
    }

    #region -- Single Responsibility Principle --
    public class  Word
    {
        public void Print()
        { }
    }

    public class QuadraticEquation
    {
        public void Calculate()
        {

        }
    }
    #endregion
}
