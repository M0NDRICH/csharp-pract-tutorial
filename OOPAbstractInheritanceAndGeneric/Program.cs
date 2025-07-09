// See https://aka.ms/new-console-template for more information
using OOPAbstractInheritanceAndGeneric;
using System;

namespace OPPAbstractInheritanceAndGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- OOP --
            /*
            var iphone13 = new IPhone();
            iphone13.Color = "Silver";
            iphone13.Shape = "Square";
            iphone13.PowerOn();
            */
            /*
            iphone13._microChip = "Chip001";
            iphone13.ConnectMainboardToPowerSupply();
            iphone13.OpenWifiChip();
            */

            /*
            new SampleOperation()
                .Process();
            */
            #endregion

            #region -- Abstract VS Interface --

            var pdf = new PDF();
            var word = new Word();
            Document pdfDoc = new PDF();
            Document WordDoc = new Word();

            var excel = new Excel();
            IDokumento dokumentoExcel = new Excel();
            dokumentoExcel.Print();

            Word newWord = new NewDocument();
            IDoc1 doc1Excel = new NewDocument();
            IDoc2 doc2Excel = new NewDocument();

            #endregion

            #region -- Generic --

            var processor = new SampleGeneric<TagaMultiply>();
            processor.Process(9, 9);
            var processorDiv = new SampleGeneric<TagaDivide>();
            processorDiv.Process(9, 9);

            #endregion
        }
    }
}