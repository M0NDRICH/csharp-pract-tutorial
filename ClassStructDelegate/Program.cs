// See https://aka.ms/new-console-template for more information
using System;

namespace ClassStructDelegate
{
    class Program
    {
        static void Main(string[] ars)
        {
            #region -- Not using a Class --

            string firstNameJuan;
            string lastNameJuan;

            string firstNamePedro;
            string lastNamePedro;

            #endregion

            #region -- Using a class --

            var juan = new Person();
            juan.FirstName = "Juan";
            juan.LastName = "Bautista";

            var pedro = new Person()
            {
                FirstName = "Pedro",
                LastName = "Ewan"
            };

            var maria = new Person("Maria")
            {
                LastName = "Ewan din"
            };
            var frace = new Person("Frace", "Marteja");
            #endregion

            #region -- Class --

            var person = new Person("ProGrammer", "TV")
            {
                NickName = "Frace",
                BirthDate = new DateTime(1990, 8, 1)
            };
            person.NickNameHandler += NickNameChanging;
            person.Update(10, "Ace");
            Console.WriteLine($@"
                                Name: {person.FullName}
                                Age: {person.GetAge()}
                                Nickname: {person.NickName}
                                SampleInt: {person.Sample}");
            #endregion

            #region -- Struct --
            var apple = new Fruit() { Name = "Apple", Color = "Red" };
            var mango = new Fruit("Mango", "Yellow");
            #endregion

            #region -- Delegate --

            var luffy = new Person("Luffy", "Monkey")
            {
                NickName = "Strawhat"
            };
            luffy.FavoriteFruits.Add(new Fruit("Banana", "Yellow"));

            person.AddFavoriteFruit(new  Fruit("Mango", "Yellow"), AddedNewFruit);
            person.DeleteFavoriteFruit(person.FavoriteFruits[0], (prutas) =>
            {
                Console.WriteLine($"Deleted Fruit:; {prutas.Name}");
                return 1;
            });
            Console.WriteLine($"*** -- {luffy.FullName} --Favorite Fruits***");
            foreach(var food in luffy.FavoriteFruits)
                Console.WriteLine(food.Name);
            #endregion
        }

        #region -- Methods --
        private static int AddedNewFruit(Fruit prutas)
        {
            Console.WriteLine($"Added fruit: {prutas.Name}");
            return 1;
        }
        private static void NickNameChanging(object sender, NickNameArgs args)
        {
            Console.WriteLine($"Nickname is changing to: {args.NickName}");
        }
        #endregion
    }
}
