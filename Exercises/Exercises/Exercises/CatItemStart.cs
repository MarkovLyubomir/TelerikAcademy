using System;

namespace CatsSystem
{
    public class CatItemStart
    {
        public static void Main()
        {
            var jackOwner = new Owner("Jack", "Ivanov");
            var jhonOwner = new Owner("Jhon", "Ivanov");

            var cat = new Cat(CatColor.Blue);
            var anotherCat = new Cat(CatColor.Green);
            var yetAnotherCat = new Cat(CatColor.Red);


            jackOwner.AddCat(cat, "Maca");
            jackOwner.AddCat(anotherCat, "Pesho");

            Console.WriteLine(jackOwner.AllCats);
        }
    }
}
