using System;
using System.Collections.Generic;

namespace Prov1_Toshihide_Sakao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book newBook = new Book();
            
            books.Add(newBook);

            newBook.PrintInfo();
            Console.ReadLine();

            Buyer guest = new Buyer();
            guest.Buy(newBook);
            Console.ReadLine();
        }
    }
}
