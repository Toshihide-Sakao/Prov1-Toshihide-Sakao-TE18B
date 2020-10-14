using System;

namespace Prov1_Toshihide_Sakao
{
    public class Book
    {
        public int price;
        string name;
        int rarity;
        string category;
        int actualValue;
        bool cursed;
        static Random generator = new Random();

        //array for names
        public static string[] names = new string[] {"Purple Midnight", "Rules and Roses", "Alpha Sinking", "Shiled Of Wiverns", "Ragnorak Retaliating"};

        //array for categories
        public static string[] categories = new string[] {"Mystery", "Fantasy", "Horror", "Unknown"};

        public Book()
        {
            //The value will be somewhere between 30 and 120
            actualValue = generator.Next(30, 121);

            //The rarity will be somewhere from 1 to 3
            rarity = generator.Next(1, 4);

            //Randomizes cursed, by randomizing a number between 0 or 1 (0 is true and 1 is false)
            int trueOrFalse = generator.Next(2);

            if (trueOrFalse == 0)
                cursed = true;
            else
                cursed = false;

            //Randomizing name
            int chosenBook = generator.Next(names.Length);
            name = names[chosenBook];

            //Randomizing Category
            int chosenCategory = generator.Next(categories.Length);
            category = categories[chosenCategory];

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Info of {name}:");
            Console.WriteLine("");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Rarity: {rarity}");
            Console.WriteLine($"Category: {category}");
            Console.WriteLine($"Price: {price}");
        }
        public int Evaluate()
        {
            int correctPrice = actualValue * rarity;
            price = (generator.Next(correctPrice * 5, correctPrice * 15) ) / 10;

            return price;
        }
        public string GetCategory()
        {
            return category;
        }
        public string GetName()
        {
            return name;
        }
        public bool IsCursed()
        {
            //generates a random number which represents the percentage
            int percentage = generator.Next(0, 11);

            //8 or more than it will return the opposite
            if (percentage >= 8)
            {
                return !cursed;
            }
            else 
            {
                return cursed;
            }
        }

    }
}
