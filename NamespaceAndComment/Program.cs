// See https://aka.ms/new-console-template for more information
using NamespaceAndComment.Fruits;
using NamespaceAndComment.Heroes.MobileLegend.Asssassins;
using NamespaceAndComment.Heroes.MobileLegend.Fighters;
using NamespaceAndComment.Heroes.MobileLegend.Mages;
using NamespaceAndComment.Heroes.Pinoy.Bisaya;
using PinoyHeroNaBisaya = NamespaceAndComment.Heroes.Pinoy.Bisaya; // ALIAS
using NamespaceAndComment.Heroes.Pinoy.Tagalog;
using System;
using System.Collections;

namespace NamespaceAndComment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- Namespace Demo --

            Console.WriteLine("Namespace Test!");
            var queue = new Queue();
            var banana = new Banana();
            var apple = new NamespaceAndComment.Fruits.Apple();

            var alpha = new Alpha();
            var ling = new Ling();

            var valir = new Valir();

            var rizal = new Rizal();
            var kudarat = new Kudarat();

            var lapulapu = new PinoyHeroNaBisaya.LapuLapu();
            #endregion]

            #region -- Comment Demo --

            //this num1 variable is for demo purposes only
            var num1 = 0;
            var num2 = 1; //this is another sample for demo purposely only
            var num3 = 1 + 5; //this is a sample on how to "ADD" to numbers
            /*
                test
                multiple
                comment 
                only
            */
            var testCommentOnly = "";

            #endregion
        }
    }
}
