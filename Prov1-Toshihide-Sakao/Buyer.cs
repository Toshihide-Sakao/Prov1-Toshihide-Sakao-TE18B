using System;

namespace Prov1_Toshihide_Sakao
{
    public class Buyer
    {
        public string name;
        static string[] names = new string[] { "Kasper", "Johannes", "Axel", "Love", "Atabakan" };
        int money;
        string interestedCategory;
        string[] booksOwned;
        static Random generator = new Random();

        public Buyer()
        {
            //randomizing name
            int chosenName = generator.Next(names.Length);
            name = names[chosenName];

            //randomizing amount of money (between 50, 250)
            money = generator.Next(50, 251);

            //randomizing intereseted category
            int chosenCategory = generator.Next(Book.categories.Length);
            interestedCategory = Book.categories[chosenCategory];

            //how many books he has
            booksOwned = new string[generator.Next(4)];

            if (booksOwned.Length == 0)
            {
            }
            else
            {
                for (int i = 0; i < booksOwned.Length; i++)
                {
                    //Giving the book names to owned books
                    booksOwned[i] = Book.names[generator.Next(Book.names.Length)];
                }
            }
        }

        public void Buy(Book book)
        {
            if (book.price <= money)
            {
                Console.WriteLine($"{name} bought {book.GetName()} ");
            }
            else 
            {
                Console.WriteLine($"{name} is too poor to buy {book.GetName()}");
            }
        }
    }
}
