// See https://aka.ms/new-console-template for more information
//using System.Collections.Generic;

namespace ArraysEnumerableCollectionAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -- Declaration --
            /*
            int[] numbers = new int[10];
            int[] numbersWithInit = new int[] { 1, 2, 3 };
            int[][] multiNumbers = new int[3][]
            {
                new int[3] {1, 2, 3},
                new int[3] {1, 2, 3},
                new int[3] {1, 2, 3}
            };
            int[,] otherNumbers = new int[2, 2]; // [,] = means multidimensional
            */

            var numbers = new int[10];
            var numbersWithInit = new int[] { 1, 2, 3 };
            var multiNumbers = new int[3][]
            {
                new int[3] {1, 2, 3},
                new int[3] {1, 2, 3},
                new int[3] {1,2, 3},
            };
            #endregion

            #region -- Array Sample --
            //var names = new[] { "mon", "rich", "coder" };
            //Console.WriteLine("Before Update");
            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //names[1] = "hardware";
            //Console.WriteLine("After update");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine($"name at index 2: {names[2]}");

            //Multi-Dimensional
            var rowsAndCells = new int[3][]{
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 }
            };
            for (var row = 0; row < rowsAndCells.Length; row++)
            {
                //Console.WriteLine($"row: {row}");
                foreach (var cell in rowsAndCells[row])
                {
                    //Console.WriteLine($"value: {cell}");
                }
            }
            
            //Console.WriteLine($"rowsAndCells in row 2 and cell 1:{rowsAndCells[1][0]}");
            #endregion

            #region -- Enumerable, Collection and List --

            #region -- Enumerable --
            var countries = new[] { "Philippines", "USA", "Canada", "Pakistan", "Afghanistan" };
            IEnumerable<string> enumCountries = countries;
            //enumCountries[0] = "PHIL";
            Console.WriteLine("Enumerable");
            foreach (var country in enumCountries)
            {
                Console.WriteLine(country);
            }
            #endregion

            #region -- Collection --
            ICollection<string> colCountries = new List<string>(countries);
            colCountries.Add("Australia");
            colCountries.Remove("USA");
            //Console.WriteLine("****************");
            //colCountries[0] = "Sample"; 
            //Console.WriteLine("Collection: ");
            foreach (var country in colCountries)
            {
                //Console.WriteLine(country);
            }
            #endregion

            #region -- List --

            var listCountries = new List<string>(countries);//with initial value from array
            var listInitCountries = new List<string> //with initial value
            {
                "Philippines",
                "USA"
            };
            var listCountriesNew = new List<string>();
            listCountriesNew.Add("Philippines");
            listCountriesNew.Add("USA");
            listCountriesNew.AddRange(new[] { "Canada", "Australia" });
            listCountriesNew.Remove("Philippines");
            listCountriesNew[0] = "America";
            Console.WriteLine("List of countries");
            for(var index = 0; index < listCountriesNew.Count; index++)
            {
                Console.WriteLine($"{index}:{listCountriesNew[index]}");
            }
            #endregion
            #endregion

        }
    }
}